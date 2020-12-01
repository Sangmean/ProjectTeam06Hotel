using System;
using System.ComponentModel;
using System.Linq;
using VancouverHotelCodeFirstFromDB;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;
using EFControllerUtilities;
using SeedDatabaseExtensions;
using System.Data;

namespace ProjectTeam06Hotel
{
    public partial class RoomInfoForm : Form
    {

        private DataSet hotelDataSet;
        private VancouverHotelEntities context;
        private int selectedRoomId;
        public RoomInfoForm()
        {
            InitializeComponent();
            this.Text = "Room Information Form";

            hotelDataSet = new DataSet()
            {
                DataSetName = "VancouverHOtelDataSet",
            };

            context = new VancouverHotelEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.SeedDatabase();

            this.Load += (s, e) => RoomInfoForm_Load();
            buttonRoomTypeAdd.Click += ButtonRoomTypeAdd_Click;
            buttonRoomTypeUpdate.Click += ButtonRoomTypeUpdate_Click;
            buttonRoomTypeDelete.Click += ButtonRoomTypeDelete_Click;
            buttonBackupDatabase.Click += (s, e) => BackupDataSetToXML();
            dataGridViewRoom.SelectionChanged += DataGridViewRoom_SelectionChanged;
    
        }

        private void ButtonRoomTypeDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRoom.SelectedRows)
            {
                RoomType roomType = row.DataBoundItem as RoomType;
                context.RoomTypes.Remove(roomType);
            }

            context.SaveChanges();
            RoomInfoForm_Load();

        }

        private void ButtonRoomTypeUpdate_Click(object sender, EventArgs e)
        {
            if ((dataGridViewRoom.SelectedRows == null))
            {
                MessageBox.Show("Room to be updated must be selected");
                return;
            }

            RoomType roomType = new RoomType();
            string selectedStatus = listBoxStatus.SelectedItem.ToString();

            roomType.RoomTypeId = selectedRoomId;
            roomType.RoomTypeName = textBoxAddRoomType.Text;      
            roomType.PricePerNight = decimal.Parse(textBoxPricePerNight.Text);
            roomType.Status = selectedStatus;
            roomType.Capacity = int.Parse(textBoxCapacity.Text);
  
            if (Controller<VancouverHotelEntities, RoomType>.UpdateEntity(roomType) == false)
            {
                MessageBox.Show("Cannot update room type to database"); 
                return;
            }

            context = new VancouverHotelEntities();
            RoomInfoForm_Load();
            context.SaveChanges();
        }

        private void DataGridViewRoom_SelectionChanged(object sender, EventArgs e)
        {  
            RoomType roomType = new RoomType();

            foreach (DataGridViewRow row in dataGridViewRoom.SelectedRows)
                 roomType = row.DataBoundItem as RoomType;

            textBoxAddRoomType.Text = roomType.RoomTypeName;
            textBoxPricePerNight.Text = roomType.PricePerNight.ToString();
            textBoxCapacity.Text = roomType.Capacity.ToString();
            selectedRoomId = roomType.RoomTypeId;

            if (roomType.Status == "Occupied")
                listBoxStatus.SelectedIndex = 0;
            else
                listBoxStatus.SelectedIndex = 1;
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

            if (Controller<VancouverHotelEntities, RoomType>.AddEntity(roomType) == null)
            {
                MessageBox.Show("Cannot add student to database");
                return;
            }

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

            //this.dataGridViewRoom.Columns["Rooms"].Visible = false;
            dataGridViewRoom.DataSource = context.RoomTypes.ToList();

        }

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

        /// <summary>
		/// Back up a DataSet to an XML file. 
		/// 
		/// File is named using the 
		/// <see cref="DataSet.DataSetName"/> with .xml appended
		/// </summary>
		/// <param name="dataSet">DataSet to be backked up</param>
		/// <param name="fileName">Name of the xml file (should have .xml extension)</param>
		public void BackupDataSetToXML()
        {
            if (hotelDataSet == null)
            {
                Debug.WriteLine("BackupDataSetToXML: Error - null dataset");
                return;
            }

            // writes the DataSet to an xml file including the schema

            Debug.WriteLine("BackupDataSetToXML: backing up to " + hotelDataSet);

            hotelDataSet.WriteXml(hotelDataSet.DataSetName + ".xml", XmlWriteMode.WriteSchema);
        }

    }
}
