﻿using System;
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
    public partial class PaymentForm : Form
    {

        private VancouverHotelEntities context;
        public PaymentForm()
        {
            InitializeComponent();

            

            this.Load += PaymentForm_Load;

            // register event handler for when a guest is selected
            listBoxReservedGuestName.SelectedIndexChanged += (s, e) => GetPayment();
            listBoxReservedGuestID.SelectedIndexChanged += (s, e) => GetPayment();

            // always dispose of the context when the form is closed.
            // this.FormClosed += (s, e) => context.Dispose();

            buttonPay.Click += ButtonPay_Click;
        }

        //select guest and reservation id
        private void GetPayment()
        {
            {
                if (!(listBoxReservedGuestID.SelectedItem is Payment pay))
                    return;
                textBoxGuestID.Text = pay.GuestId.ToString();
                
                textBoxReservationID.Text = pay.ReservationId.ToString();
            }
        }

        //pay room 
        private void ButtonPay_Click(object sender, EventArgs e)
        {
            int reservationID = listBoxReservedGuestID.SelectedIndex + 1;
            int guestID = listBoxReservedGuestName.SelectedIndex + 1;
            // get the guest data from the textboxes

            Payment pay = new Payment()
            {
                ReservationId = reservationID,
                GuestId = guestID,
                PaymentId = Convert.ToInt32(textBoxPaymentID.Text),
                Amount = Convert.ToInt32(textBoxAmount.Text),
                PaymentType = textBoxPayType.Text
            };            

            // now update the db

            if (Controller<VancouverHotelEntities, Payment>.AddEntity(pay) == null)
            {
                MessageBox.Show("Cannot add payment to database");
                return;
            }
            InitializeDataGridView<Payment>(dataGridViewPayments, "Payment");

            context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.Payments.Load();
            context.SaveChanges();

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            this.Tag = null;

            this.Text = "Payment Form";
            context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.Payments.Load();
            context.SaveChanges();
            // bind the listbox of guest and rooms

            listBoxReservedGuestName.DataSource = context.Reservations.Local.ToBindingList();
            listBoxReservedGuestID.DataSource = context.Guests.Local.ToBindingList();

            // no guest or room is selected to start

            listBoxReservedGuestName.SelectedIndex = -1;
            listBoxReservedGuestID.SelectedIndex = -1;

            // set all textboxes to blank

            textBoxGuestID.ResetText();
            textBoxReservationID.ResetText();
            textBoxPaymentID.ResetText();
            textBoxAmount.ResetText();
            textBoxPayType.ResetText();

            InitializeDataGridView<Payment>(dataGridViewPayments, "Payment");

        }

        //inital datagrid
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] navProperties) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // set the handler used to delete an item. Note use of generics.

            //gridView.UserDeletedRow += GridView_UserDeletedRow<T>;

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);

            // create a binding list and set the DataSource

            gridView.DataSource = SetBindingList<T>();
        }

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
