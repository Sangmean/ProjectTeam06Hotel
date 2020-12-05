﻿using System;
using System.Windows.Forms;
using VancouverHotelCodeFirstFromDB;
using System.Diagnostics;
using SeedDatabaseExtensions;

namespace ProjectTeam06Hotel
{
    public partial class HotelMainForm : Form
    {
        public HotelMainForm()
        {
            InitializeComponent();

            this.Text = "Vancouver Beachside Hotel";
            VancouverHotelEntities context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.SeedDatabase();
            context.SaveChanges();

            // register the event handlers
            buttonAdmin.Click += ButtonAdmin_Click;
            buttonFrontDesk.Click += ButtonFrontDesk_Click;
            buttonPayment.Click += ButtonPayment_Click;
            buttonReservation.Click += ButtonReservation_Click;

        }

        private void ButtonReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservation = new ReservationForm();
            reservation.ShowDialog();
        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
            payment.ShowDialog();
        }

        private void ButtonFrontDesk_Click(object sender, EventArgs e)
        {
            GuestForm customerForm = new GuestForm();
            customerForm.ShowDialog();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            RoomInfoForm roomInfo = new RoomInfoForm();
            roomInfo.ShowDialog();
        }

    }
}
