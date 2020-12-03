using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using SeedDatabaseExtensions;
using VancouverHotelCodeFirstFromDB;

namespace ProjectTeam06Hotel
{
    public partial class ReservationForm : Form
    {
        private VancouverHotelEntities context;

        public ReservationForm()
        {
            InitializeComponent();
            this.Text = "Reservation Form";
            context = new VancouverHotelEntities();

            // register the event handkers
            this.Load += (s,e) => ReservationForm_Load();
            buttonBook.Click += ButtonBook_Click;
            buttonCancelBooking.Click += buttonCancelBooking_Click;
            buttonUpdateRoom.Click += ButtonUpdateRoom_Click;

            // register event handler for when a guest is selected
            listBoxGuestName.SelectedIndexChanged += (s, e) => GetReservation();
            listBoxRoomType.SelectedIndexChanged += (s, e) => GetReservation();
            dataGridViewReservations.SelectionChanged += DataGridViewReservation_SelectionChanged;  
        }

        /// <summary>
        /// Remove selected Row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewReservations.SelectedRows)
            {         
                Reservation reservation = row.DataBoundItem as Reservation;
                context.Reservations.Remove(context.Reservations.Find(reservation.ReservationId));
            }
            context.SaveChanges();
            ReservationForm_Load();
        }

        /// <summary>
        /// The form is initially created, but loaded each time it is shown.
        /// Reload data each time the form loaded.
        /// This is the handler for the Load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReservationForm_Load()
        {
            // bind the listbox of guest and rooms
             
            listBoxGuestName.DataSource = Controller<VancouverHotelEntities, Guest>.SetBindingList();
            listBoxRoomType.DataSource = Controller<VancouverHotelEntities, Room>.SetBindingList();

            // no guest or room is selected to start

            listBoxGuestName.SelectedIndex = -1;
            listBoxGuestName.SelectedIndex = -1;

            // set all textboxes to blank

            textBoxGuestID.ResetText();
            textBoxRoomID.ResetText();
            textBoxResevationID.ResetText();

            InitializeDataGridView<Reservation>(dataGridViewReservations, "Reservations");
            this.dataGridViewReservations.Columns["Guest"].Visible = false;
            this.dataGridViewReservations.Columns["Payments"].Visible = false;
            this.dataGridViewReservations.Columns["Room"].Visible = false;
            this.dataGridViewReservations.Columns["RoomReservations"].Visible = false;

            dataGridViewReservations.DataSource = context.Reservations.ToList();

            context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.Payments.Load();
            context.SaveChanges();
        }

        private void DataGridViewReservation_SelectionChanged(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            foreach (DataGridViewRow row in dataGridViewReservations.SelectedRows)
                reservation = row.DataBoundItem as Reservation;

            textBoxResevationID.Text = reservation.ReservationId.ToString();
            textBoxGuestID.Text = reservation.GuestId.ToString();
            textBoxRoomID.Text = reservation.RoomId.ToString();
            textBoxNumberOfGuests.Text = reservation.NumberOfGuest.ToString();
            dateTimePickerReservation.Text = reservation.ReservationDate;
            dateTimePickerCheckin.Text = reservation.CheckInDate;
            dateTimePickerCheckOut.Text = reservation.CheckOutDate;
        }

        //select guest and room
        private void GetReservation()
        {
            {
                if (!(listBoxGuestName.SelectedItem is Guest guest))
                    return;
                textBoxGuestID.Text = guest.GuestId.ToString();
                if (!(listBoxRoomType.SelectedItem is Room room))
                    return;
                textBoxRoomID.Text = room.RoomId.ToString();
            }
        }

        /// <summary>
        /// Update the db with the new reservation data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateRoom_Click(object sender, EventArgs e)
        {
            if ((dataGridViewReservations.SelectedRows == null))
            {
                MessageBox.Show("Reservation to be updated must be selected");
                return;
            }

            if (!string.IsNullOrEmpty(textBoxResevationID.Text) && !string.IsNullOrEmpty(textBoxGuestID.Text) && !string.IsNullOrEmpty(textBoxRoomID.Text) 
                && !string.IsNullOrEmpty(dateTimePickerReservation.Text) && !string.IsNullOrEmpty(textBoxNumberOfGuests.Text) && !string.IsNullOrEmpty(dateTimePickerCheckin.Text)
                && !string.IsNullOrEmpty(dateTimePickerCheckOut.Text))
            {
                var numNight = dateTimePickerCheckOut.Value.Day - dateTimePickerCheckin.Value.Day;
                var reservation = context.Reservations.Find(int.Parse(textBoxResevationID.Text));
                reservation.GuestId = int.Parse(textBoxGuestID.Text);
                reservation.RoomId = int.Parse(textBoxRoomID.Text);
                reservation.ReservationDate = dateTimePickerReservation.Text;
                reservation.NumberOfGuest = int.Parse(textBoxNumberOfGuests.Text);
                reservation.CheckInDate = dateTimePickerCheckin.Text;
                reservation.CheckOutDate = dateTimePickerCheckOut.Text;
                reservation.NumberOfNight = Convert.ToInt32(numNight);

                ReservationForm_Load();
                context.SaveChanges();
                MessageBox.Show("Booked Infomation has been Updated");
            }

        }

        /// <summary>
        /// Add a Reservation to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBook_Click(object sender, EventArgs e)
        {
            if (!(listBoxGuestName.SelectedItem is Guest guest))
            {
                if (!(listBoxRoomType.SelectedItem is Room room))
                {
                    MessageBox.Show("guest or room to be updated must be selected");
                    return;
                }
            }
            try { 
                // get the guest data from the textboxes

                Reservation reservation = new Reservation();

                var numNight = dateTimePickerCheckOut.Value.Day - dateTimePickerCheckin.Value.Day;

                //reservation.ReservationId = Convert.ToInt32(textBoxResevationID.Text);
                reservation.GuestId = Convert.ToInt32(textBoxGuestID.Text);
                reservation.RoomId = Convert.ToInt32(textBoxRoomID.Text);
                reservation.ReservationDate = dateTimePickerReservation.Text;
                reservation.NumberOfGuest = Convert.ToInt32(textBoxNumberOfGuests.Text);
                reservation.CheckInDate = dateTimePickerCheckin.Text;
                reservation.CheckOutDate = dateTimePickerCheckOut.Text;
                reservation.NumberOfNight = Convert.ToInt32(numNight);

                if (InfoIsInvalid(reservation))
                {
                    MessageBox.Show("Reservation Information is missing");
                }

                // now update the db

                if (Controller<VancouverHotelEntities, Reservation>.AddEntity(reservation) == null)
                {
                    MessageBox.Show("Cannot add reservation to database");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to book a reservation to database. Please fill missing info");
            }


            InitializeDataGridView<Reservation>(dataGridViewReservations, "Reservation");

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
            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);
            gridView.DataSource = SetBindingList<T>();
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

        /// <summary>
        /// Make sure all reservation info exists and is not blank
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns></returns>
        private bool InfoIsInvalid(Reservation reservation)
        {
            return (reservation.ReservationDate == null || reservation.ReservationDate.Trim().Length == 0 ||
                    reservation.NumberOfGuest == null || reservation.NumberOfGuest.ToString().Trim().Length == 0 ||
                    reservation.CheckInDate == null || reservation.CheckInDate.Trim().Length == 0 ||
                    reservation.CheckOutDate == null || reservation.CheckOutDate.Trim().Length == 0 
                    );
        }
    }

}