using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using EFControllerUtilities;
using SeedDatabaseExtensions;
using VancouverHotelCodeFirstFromDB;

namespace ProjectTeam06Hotel
{
    public partial class PaymentForm : Form
    {

        private VancouverHotelEntities context;
        public PaymentForm()
        {
            InitializeComponent();

            this.Text = "Payment Form";
            context = new VancouverHotelEntities();

            // register the event handlers
            this.Load += (s, e) => PaymentForm_Load();  
            buttonPay.Click += ButtonPay_Click;
            buttonPayUpdate.Click += ButtonPayUpdate_Click;
            buttonPayDelete.Click += ButtonPayDelete_Click;

            // register event handler for when a reservation is selected
            dataGridViewReservationInfo.SelectionChanged += DataGridViewReservationInfo_SelectionChanged;
            dataGridViewPayments.SelectionChanged += DataGridViewPayments_SelectionChanged;
        }


        /// <summary>
        /// The form is initially created, but loaded each time it is shown.
        /// Reload data each time the form loaded.
        /// This is the handler for the Load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentForm_Load()
        {

            InitializeDataGridView<Payment>(dataGridViewPayments, "Payment");
            this.dataGridViewPayments.Columns["Guest"].Visible = false;
            this.dataGridViewPayments.Columns["reservation"].Visible = false;


            InitializeDataGridView<Reservation>(dataGridViewReservationInfo, "Reservations");
            this.dataGridViewReservationInfo.Columns["Guest"].Visible = false;
            this.dataGridViewReservationInfo.Columns["Payments"].Visible = false;
            this.dataGridViewReservationInfo.Columns["Room"].Visible = false;
            this.dataGridViewReservationInfo.Columns["RoomReservations"].Visible = false;

            dataGridViewReservationInfo.DataSource = context.Reservations.ToList();

            // set all textboxes to blank

            textBoxFirstName.ResetText();
            textBoxLastName.ResetText();
            textBoxNumberOfNight.ResetText();
            textBoxPayType.ResetText();
            textBoxPricePerNight.ResetText();
            textBoxTotalAmount.ResetText();

        }

        /// <summary>
        /// Delete a selected Payment from db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPayDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPayments.SelectedRows)
            {
                Payment payment = row.DataBoundItem as Payment;
                context.Payments.Remove(payment);
            }

            context.SaveChanges();
            PaymentForm_Load();
        }

        /// <summary>
        /// Get a selected reservation from the gridView and fill in the textboxes with the info.
        /// </summary>
        private void DataGridViewReservationInfo_SelectionChanged(object sender, EventArgs e)
        {

            Reservation reservation = new Reservation();

            foreach (DataGridViewRow row in dataGridViewReservationInfo.SelectedRows)
                reservation = row.DataBoundItem as Reservation;


            if (!(reservation.ReservationId > 0))
                return;

            int roomTypeId = (int)reservation.Room.RoomTypeId;
            RoomType roomType = context.RoomTypes.Find(roomTypeId);
            
            textBoxFirstName.Text = reservation.Guest.GuestFirstName;
            textBoxLastName.Text = reservation.Guest.GuestLastName;
            textBoxNumberOfNight.Text = reservation.NumberOfNight.ToString();
            textBoxPricePerNight.Text = roomType.PricePerNight.ToString();
            textBoxTotalAmount.Text = (reservation.NumberOfNight * roomType.PricePerNight).ToString();
        }

        /// <summary>
        /// Add a payment to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPay_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            foreach (DataGridViewRow row in dataGridViewReservationInfo.SelectedRows)
                reservation = row.DataBoundItem as Reservation;
            // get the guest data from the textboxes

            // check if it's already paid
            if (IsPaid(reservation))
            {
                MessageBox.Show("The reservation is already paid");
                return;
            }

            Payment pay = new Payment()
            {
                ReservationId = reservation.ReservationId,
                GuestId = reservation.GuestId,
                Amount = Convert.ToDecimal(textBoxTotalAmount.Text),
                PaymentType = textBoxPayType.Text.ToString()
            };

            if(pay.PaymentType.Trim() == null || pay.PaymentType.Length == 0)
            {
                MessageBox.Show("Payment Type is requird");
                return;
            }

            // now update the db

            if (Controller<VancouverHotelEntities, Payment>.AddEntity(pay) == null)
            {
                MessageBox.Show("Cannot add payment to database");
                return;
            }

            context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.Payments.Load();
            context.SaveChanges();

            PaymentForm_Load();
            context.SaveChanges();
        }


        /// <summary>
        /// Set up the datagridview controls
        /// </summary>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] navProperties) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);

            // create a binding list and set the DataSource

            gridView.DataSource = SetBindingList<T>();
        }

        /// <summary>
        /// Update the db with the payment data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPayUpdate_Click(object sender, EventArgs e)
        {
            if ((dataGridViewPayments.SelectedRows == null))
            {
                MessageBox.Show("Payment to be updated must be selected");
                return;
            }

            Payment selectedPayment = new Payment();

            foreach (DataGridViewRow row in dataGridViewPayments.SelectedRows)
                selectedPayment = row.DataBoundItem as Payment;
  

            Payment payment = new Payment();
            payment.PaymentId = selectedPayment.PaymentId;
            payment.PaymentType = textBoxPayType.Text.ToString();
            payment.ReservationId = selectedPayment.ReservationId;
            payment.GuestId = selectedPayment.GuestId;
            payment.Amount = selectedPayment.Amount;

            if (payment.PaymentType.Trim() == null || payment.PaymentType.Length == 0)
            {
                MessageBox.Show("Payment Type is requird");
                return;
            }

            if(payment.PaymentType == selectedPayment.PaymentType)
            {
                MessageBox.Show("The payment already exists");
                return;
            }

            if (Controller<VancouverHotelEntities, Payment>.UpdateEntity(payment) == false)
            {
                MessageBox.Show("Cannot update payment type to database");
                return;
            }

            context = new VancouverHotelEntities();
            PaymentForm_Load();
            context.SaveChanges();
        }

        /// <summary>
        /// Get a selected payment from the gridView and fill in the textboxe with the info.
        /// </summary>
        private void DataGridViewPayments_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewReservationInfo.ClearSelection();
            Payment payment = new Payment();

            foreach (DataGridViewRow row in dataGridViewPayments.SelectedRows)
                payment = row.DataBoundItem as Payment;

            textBoxPayType.Text = payment.PaymentType;

        }

        /// <summary>
        /// See if a reservation is alrady paid 
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        private bool IsPaid(Reservation reservation)
        {
            return context.Payments.Any(c => c.ReservationId == reservation.ReservationId);
        }

        /// <summary>
        /// Generic method to load a table and set it to a BindingList for use
        /// by DataGridView.
        /// 
        /// Can be used to reload tables from db. This is done in the generic
        /// addupdate form processing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private BindingList<T> SetBindingList<T>() where T : class
        {
            DbSet<T> dbSet = context.Set<T>();

            dbSet.Load();
            BindingList<T> list = dbSet.Local.ToBindingList<T>();
            return list;
        }


        private void GridView_DataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }
    }
}
