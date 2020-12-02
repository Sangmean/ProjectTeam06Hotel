using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VancouverHotelCodeFirstFromDB;
using System.Data.Entity;
using System.Diagnostics;
using SeedDatabaseExtensions;
using EFControllerUtilities;

namespace ProjectTeam06Hotel
{
    public partial class GuestForm : Form
    {
        private VancouverHotelEntities context;
        public GuestForm()
        {
            InitializeComponent();

            this.Text = "Guest Form";
            context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            // context.SeedDatabase();

            // register the event handlers
            this.Load += (s, e) => GuestForm_Load();
            btnAddCustomerInfo.Click += BtnAddCustomerInfo_Click;
            btnUpdateCustomer.Click += BtnUpdateCustomer_Click;
            btnDeleteCustomer.Click += BtnDeleteCustomer_Click;

            dataGridViewCustomer.CellClick += DataGridViewCustomer_CellClick;
        }

        /// <summary>
        /// Delete a selected guest from db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewCustomer.SelectedRows)
            {
                Guest guest = row.DataBoundItem as Guest;
                context.Guests.Remove(guest);
            }
            context.SaveChanges();
            GuestForm_Load();
        }

        /// <summary>
        /// Update the db with the new guest data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUpdateCustomerId.Text) && !string.IsNullOrEmpty(txtBoxUpdateFirstName.Text) && !string.IsNullOrEmpty(txtBoxUpdateLastName.Text) && !string.IsNullOrEmpty(txtBoxUpdateCustomerAddress.Text)
                && !string.IsNullOrEmpty(txtBoxUpdateCity.Text) && !string.IsNullOrEmpty(txtBoxUpdatePostCode.Text) && !string.IsNullOrEmpty(txtBoxUpdateCountry.Text)
                && !string.IsNullOrEmpty(txtBoxUpdateEmail.Text) && !string.IsNullOrEmpty(txtBoxUpdateCusotmerPhone.Text))
            {
                var guest = context.Guests.Find(int.Parse(txtBoxUpdateCustomerId.Text));
                guest.GuestFirstName = txtBoxUpdateFirstName.Text;
                guest.GuestLastName = txtBoxUpdateLastName.Text;
                guest.Adress = txtBoxUpdateCustomerAddress.Text;
                guest.City = txtBoxUpdateCity.Text;
                guest.PostCode = txtBoxUpdatePostCode.Text;
                guest.Country = txtBoxUpdateCountry.Text;
                guest.Email = txtBoxUpdateEmail.Text;
                guest.Phone = txtBoxUpdateCusotmerPhone.Text;

                context.SaveChanges();
                GuestForm_Load();
            }
        }


        /// <summary>
        /// Add a Guest to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddCustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Guest guest = new Guest()
                {
                    GuestFirstName = txtBoxAddFirstName.Text,
                    GuestLastName = txtBoxAddLastName.Text,
                    Adress = txtBoxAddCustomerAddress.Text,
                    City = txtBoxAddCity.Text,
                    PostCode = txtBoxAddPostCode.Text,
                    Country = txtBoxAddCountry.Text,
                    Email = txtBoxAddEmail.Text,
                    Phone = txtBoxAddCustomerPhone.Text
                };

                if (GuestInfoInvalid(guest))
                {
                    MessageBox.Show("Guest infomation is missing");
                    return;
                }

                if (Controller<VancouverHotelEntities,Guest>.AddEntity(guest) == null)
                {
                    MessageBox.Show("Cannot add guest infomation to database");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to add guest type to database");
            }

            txtBoxAddFirstName.Clear();
            txtBoxAddLastName.Clear();
            txtBoxAddCustomerAddress.Clear();
            txtBoxAddCity.Clear();
            txtBoxAddPostCode.Clear();
            txtBoxAddCountry.Clear();
            txtBoxAddEmail.Clear();
            txtBoxAddCustomerPhone.Clear();

            GuestForm_Load();
            context.SaveChanges();
        }

        /// <summary>
        /// Set up all of the datagridview controls
        /// </summary>
        private void GuestForm_Load()
        {
            // common setup for datagridview controls

            InitializeDataGridView<Guest>(dataGridViewCustomer, "Guest");

            this.dataGridViewCustomer.Columns["Payments"].Visible = false;
            this.dataGridViewCustomer.Columns["Reservations"].Visible = false;
            dataGridViewCustomer.DataSource = context.Guests.ToList();

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

        private void DataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomer.SelectedRows.Count > 0)
            {
                var row = dataGridViewCustomer.SelectedRows[0];
                var guest = (Guest)row.DataBoundItem;
                txtBoxUpdateCustomerId.Text = guest.GuestId.ToString();
                txtBoxUpdateFirstName.Text = guest.GuestFirstName;
                txtBoxUpdateLastName.Text = guest.GuestLastName;
                txtBoxUpdateCustomerAddress.Text = guest.Adress;
                txtBoxUpdateCity.Text = guest.City;
                txtBoxUpdatePostCode.Text = guest.PostCode;
                txtBoxUpdateCountry.Text = guest.Country;
                txtBoxUpdateEmail.Text = guest.Email;
                txtBoxUpdateCusotmerPhone.Text = guest.Phone;
            }
        }

        /// <summary>
        /// Make sure all guest info exists and is not blank
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        private bool GuestInfoInvalid(Guest guest)
        {
            return (guest.GuestFirstName == null || guest.GuestFirstName.Trim().Length == 0 ||
                guest.GuestLastName == null || guest.GuestLastName.Trim().Length == 0 ||
                guest.Adress == null || guest.Adress.Trim().Length == 0 ||
                guest.City == null || guest.City.Trim().Length == 0 ||
                guest.PostCode == null || guest.PostCode.Trim().Length == 0 ||
                guest.Country == null || guest.Country.Trim().Length == 0 ||
                guest.Email == null || guest.Email.Trim().Length == 0 ||
                guest.Phone == null || guest.Phone.Trim().Length == 0); 
        }
    }

}
