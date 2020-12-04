using System;
using System.ComponentModel;
using System.Linq;
using VancouverHotelCodeFirstFromDB;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;
using EFControllerUtilities;
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

            // register the event handlers
            this.Load += (s, e) => RoomInfoForm_Load();
            buttonRoomTypeAdd.Click += ButtonRoomTypeAdd_Click;
            buttonRoomTypeUpdate.Click += ButtonRoomTypeUpdate_Click;
            buttonRoomTypeDelete.Click += ButtonRoomTypeDelete_Click;
            buttonBackupDatabase.Click += (s, e) => BackupDataSetToXML();
            buttonRoomAdd.Click += ButtonRoomAdd_Click;
            buttonRoomUpdate.Click += ButtonRoomUpdate_Click;
            buttonRoomDelete.Click += ButtonRoomDelete_Click;
       
            // register event handler for when a RoomType is selected
            dataGridViewRoom.SelectionChanged += DataGridViewRoom_SelectionChanged;
            dataGridViewAddRoom.SelectionChanged += DataGridViewAddRoom_SelectionChanged;
    
        }

        /// <summary>
        /// The form is initially created, but loaded each time it is shown.
        /// Reload data each time the form loaded.
        /// This is the handler for the Load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomInfoForm_Load()
        {

            InitializeDataGridView<RoomType>(dataGridViewRoom, "RoomType");
            InitializeDataGridView<Room>(dataGridViewAddRoom, "Room");

            this.dataGridViewAddRoom.Columns["Reservations"].Visible = false;
            this.dataGridViewAddRoom.Columns["RoomType"].Visible = false;
            this.dataGridViewAddRoom.Columns["RoomReservation"].Visible = false;
            this.dataGridViewAddRoom.Columns["RoomTypes"].Visible = false;

            dataGridViewRoom.DataSource = context.RoomTypes.ToList();
            dataGridViewAddRoom.DataSource = context.Rooms.ToList();

        }

        /// <summary>
        /// Set up the datagridview controls
        /// </summary>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] navProperties) where T : class
        {

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.DataSource = SetBindingList<T>();

        }

        /// <summary>
        /// Add a RoomType to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRoomTypeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                RoomType roomType = new RoomType()
                {
                    RoomTypeName = textBoxAddRoomType.Text,
                    PricePerNight = Decimal.Parse(textBoxPricePerNight.Text),
                    Capacity = int.Parse(textBoxCapacity.Text)
                };

                if (InfoIsInvalid(roomType))
                {
                    MessageBox.Show("Room information is missing.");
                    return;
                }

                if (RoomInfoExists(roomType))
                {
                    MessageBox.Show("The room informatio already exists.");
                    return;
                }

                if (Controller<VancouverHotelEntities, RoomType>.AddEntity(roomType) == null)
                {
                    MessageBox.Show("Cannot add Room information to database");
                    return;
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Unable to add room type to database.");
            }

            RoomInfoForm_Load();
            context.SaveChanges();
        }

        /// <summary>
        /// Update the db with the new RoomType data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRoomTypeUpdate_Click(object sender, EventArgs e)
        {

            if ((dataGridViewRoom.SelectedRows == null))
            {
                MessageBox.Show("Room to be updated must be selected");
                return;
            }

            try
            {
                RoomType roomType = new RoomType();

                roomType.RoomTypeId = selectedRoomId;
                roomType.RoomTypeName = textBoxAddRoomType.Text;
                roomType.PricePerNight = decimal.Parse(textBoxPricePerNight.Text);
                roomType.Capacity = int.Parse(textBoxCapacity.Text);

                if (InfoIsInvalid(roomType))
                {
                    MessageBox.Show("Room information is missing.");
                    return;
                }

                if (RoomInfoExists(roomType))
                {
                    MessageBox.Show("The room informatio already exists.");
                    return;
                }

                if (Controller<VancouverHotelEntities, RoomType>.UpdateEntity(roomType) == false)
                {
                    MessageBox.Show("Cannot update room type to database");
                    return;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Unable update room type to database");
            }

            RoomInfoForm_Load();
            context.SaveChanges();
        }

        /// <summary>
        /// Remove selected Row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRoomDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataGridViewRow row in dataGridViewAddRoom.SelectedRows)
                {
                    Room room = row.DataBoundItem as Room;
                    context.Rooms.Remove(room);
                }

                context.SaveChanges();
            }

            catch (Exception)
            {
                MessageBox.Show("The room cannot be deleted");
            }
            
            RoomInfoForm_Load();
        }

        /// <summary>
        /// Add a room to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRoomAdd_Click(object sender, EventArgs e)
        {
            RoomType roomType = new RoomType();
            string selectedStatus = listBoxStatus.SelectedItem.ToString(); // get selected status 

            foreach (DataGridViewRow row in dataGridViewRoom.SelectedRows)
                roomType = row.DataBoundItem as RoomType; // get sleceted roomType infomation

            Room room = new Room
            {
                RoomTypeId = roomType.RoomTypeId,
                Status = selectedStatus,
            };

            if (Controller<VancouverHotelEntities, Room>.AddEntity(room) == null)
            {
                MessageBox.Show("Cannot add Room to database");
                return;
            }

            RoomInfoForm_Load();
            context.SaveChanges();

        }

        /// <summary>
        /// Update the db with the new room data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRoomUpdate_Click(object sender, EventArgs e)
        {
            if ((dataGridViewAddRoom.SelectedRows == null))
            {
                MessageBox.Show("Room to be updated must be selected");
                return;
            }
            try
            {
                string selectedStatus = listBoxStatus.SelectedItem.ToString(); // get selected status 

                Room room = new Room();
                Room selectedRoom = new Room();

                foreach (DataGridViewRow row in dataGridViewAddRoom.SelectedRows)
                    selectedRoom = row.DataBoundItem as Room; // get sleceted roomType infomation


                room.RoomId = selectedRoom.RoomId;
                room.RoomTypeId = selectedRoom.RoomTypeId;

                // check if the status is the same 
                if (selectedRoom.Status == selectedStatus)
                {
                    MessageBox.Show("The room already exists");
                }

                room.Status = selectedStatus;

                if (Controller<VancouverHotelEntities, Room>.UpdateEntity(room) == false)
                {
                    MessageBox.Show("Cannot update room to database");
                    return;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Unable update room to database");
            }

            RoomInfoForm_Load();
            context.SaveChanges();

        }

        /// <summary>
        /// Delete a selected RoomType from db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRoomTypeDelete_Click(object sender, EventArgs e)
        {
            if ((dataGridViewRoom.SelectedRows == null))
            {
                MessageBox.Show("RoomType to be updated must be selected");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewRoom.SelectedRows)
            {
                RoomType roomType = row.DataBoundItem as RoomType;
                context.RoomTypes.Remove(roomType);
            }

            context.SaveChanges();
            RoomInfoForm_Load();

        }

        /// <summary>
        /// Get a selected RoomType from the gridView and fill in the textboxes and a listbox with the
        /// info.
        /// </summary>
        private void DataGridViewRoom_SelectionChanged(object sender, EventArgs e)
        {  
            RoomType roomType = new RoomType();

            foreach (DataGridViewRow row in dataGridViewRoom.SelectedRows)
                 roomType = row.DataBoundItem as RoomType;

            textBoxAddRoomType.Text = roomType.RoomTypeName;
            textBoxPricePerNight.Text = roomType.PricePerNight.ToString();
            textBoxCapacity.Text = roomType.Capacity.ToString();
            selectedRoomId = roomType.RoomTypeId;
        }

        /// <summary>
        /// Get a selected Room from the gridView and fill in a listbox with the
        /// info.
        /// </summary>
        private void DataGridViewAddRoom_SelectionChanged(object sender, EventArgs e)
        {
            Room room = new Room();

            foreach (DataGridViewRow row in dataGridViewAddRoom.SelectedRows)
                room = row.DataBoundItem as Room;

            if (room.Status == "Occupied")
                listBoxStatus.SelectedIndex = 0;
            else
                listBoxStatus.SelectedIndex = 1;
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

        /// <summary>
        /// Make sure all room info exists and is not blank
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns></returns>
        private bool InfoIsInvalid(RoomType roomType)
        {
            return (roomType.RoomTypeName == null || roomType.RoomTypeName.Trim().Length == 0 ||
                roomType.PricePerNight == null || roomType.PricePerNight.ToString().Trim().Length == 0 ||
                roomType.Capacity == null || roomType.Capacity.ToString().Length == 0);
        }

        /// <summary>
        /// See if a roonType is alrady take by anotehr item in RoomInfo
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        private bool RoomInfoExists(RoomType roomType)
        {
            return context.RoomTypes.Any(c => c.RoomTypeName == roomType.RoomTypeName) && context.RoomTypes.Any(c => c.PricePerNight == roomType.PricePerNight) &&
                 context.RoomTypes.Any(c => c.Capacity == roomType.Capacity);
        }

    }
}
