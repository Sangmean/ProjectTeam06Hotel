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
            context.SeedDatabase();

            this.Load += (s, e) => GuestForm_Load();

            btnAddCustomerInfo.Click += BtnAddCustomerInfo_Click;
        }

        private void BtnAddCustomerInfo_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtBoxAddFirstName.Text) && !string.IsNullOrEmpty(txtBoxAddLastName.Text) && !string.IsNullOrEmpty(txtBoxAddCustomerAddress.Text)
                && !string.IsNullOrEmpty(txtBoxAddCity.Text) && !string.IsNullOrEmpty(txtBoxAddPostCode.Text) && !string.IsNullOrEmpty(txtBoxAddCountry.Text)
                && !string.IsNullOrEmpty(txtBoxAddEmail.Text) && !string.IsNullOrEmpty(txtBoxAddCustomerPhone.Text))
            {
                context.Guests.Add(new Guest    
                {
                    GuestFirstName = txtBoxAddFirstName.Text,
                    GuestLastName = txtBoxAddLastName.Text,
                    Adress = txtBoxAddCustomerAddress.Text,
                    City = txtBoxAddCity.Text,
                    PostCode = txtBoxAddPostCode.Text,
                    Country = txtBoxAddPostCode.Text,
                    Email = txtBoxAddEmail.Text,
                    Phone = txtBoxAddCustomerPhone.Text
                });
                this.DialogResult = DialogResult.OK;
                
                /*dataGridViewCustomer.DataSource = context.Guests.ToList();
                context.SaveChanges();*/
            }
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
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] navProperties) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
/*
            // set the handler used to delete an item. Note use of generics.

            gridView.UserDeletedRow += GridView_UserDeletedRow<T>;

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);*/

            // create a binding list and set the DataSource

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
    }


}
