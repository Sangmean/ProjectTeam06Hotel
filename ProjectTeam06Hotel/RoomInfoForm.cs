using System;
using System.ComponentModel;
using System.Linq;
using VancouverHotelCodeFirstFromDB;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;
/*using EFControllerUtilities;*/
using SeedDatabaseExtensions;

namespace ProjectTeam06Hotel
{
    public partial class RoomInfoForm : Form
    {
        private VancouverHotelEntities context;
        public RoomInfoForm()
        {
            InitializeComponent();
            this.Text = "Room Information Form";

            context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.SeedDatabase();

            this.Load += (s, e) => RoomInfoForm_Load();
            buttonRoomTypeAdd.Click += ButtonRoomTypeAdd_Click;
        }

        private void ButtonRoomTypeAdd_Click(object sender, EventArgs e)
        {
            string selectedStatus = listBoxStatus.SelectedItem.ToString();


            RoomType roomType = new RoomType()
            {
                RoomTypeName = textBoxAddRoomType.Text,
                PricePerNight = Decimal.Parse(textBoxPricePerNight.Text),
                Status = selectedStatus,
                Capacity = int.Parse(textBoxCapacity.Text)
            };
/*
            if (Controller<VancouverHotelEntities, RoomType>.AddEntity(roomType) == null)
            {
                MessageBox.Show("Cannot add student to database");
                return;
            }
*/
            RoomInfoForm_Load();
            context.SaveChanges();
    
        }

        /// <summary>
        /// Set up all of the datagridview controls
        /// </summary>
        private void RoomInfoForm_Load()
        {
            // common setup for datagridview controls

            InitializeDataGridView<RoomType>(dataGridViewRoom, "RoomType");

            this.dataGridViewRoom.Columns["Rooms"].Visible = false;
            dataGridViewRoom.DataSource = context.RoomTypes.ToList();

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
