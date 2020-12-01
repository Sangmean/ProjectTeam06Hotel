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
            context.Database.Log = (s => Debug.Write(s));
            context.SeedDatabase();
            context.SaveChanges();

            this.Load += ReservationForm_Load;


            // register event handler for when a guest is selected
            listBoxGuestName.SelectedIndexChanged += (s, e) => GetReservation();
            listBoxRoomType.SelectedIndexChanged += (s, e) => GetReservation();

            // always dispose of the context when the form is closed.
            // this.FormClosed += (s, e) => context.Dispose();

            buttonBook.Click += ButtonBook_Click;
            // buttonCancelBooking.Click += DeleteBook_Click;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
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

            InitializeDataGridView<Reservation>(dataGridViewReservations, "Reservations");

            context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.Payments.Load();
            context.SaveChanges();
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

        //book room
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
            // get the guest data from the textboxes

            Reservation reservation = new Reservation();

            reservation.ReservationId = Convert.ToInt32(textBoxResevationID.Text);
            reservation.GuestId = Convert.ToInt32(textBoxGuestID.Text);
            reservation.RoomId = Convert.ToInt32(textBoxRoomID.Text);
            reservation.ReservationDate = DateTime.Parse(textBoxReservationDate.Text);
            reservation.NumberOfGuest = Convert.ToInt32(textBoxNumberOfGuests.Text);
            reservation.CheckInDate = DateTime.Parse(textBoxCheckinDate.Text);
            reservation.CheckOutDate = DateTime.Parse(textBoxCheckoutDate.Text);

            // now update the db

            if (Controller<VancouverHotelEntities, Reservation>.AddEntity(reservation) == null)
            {
                MessageBox.Show("Cannot add reservation to database");
                return;
            }


            InitializeDataGridView<Reservation>(dataGridViewReservations, "Reservation");


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