namespace ProjectTeam06Hotel
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReservationID = new System.Windows.Forms.Label();
            this.labelGuestID = new System.Windows.Forms.Label();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.labelReservationDate = new System.Windows.Forms.Label();
            this.labelCheckindate = new System.Windows.Forms.Label();
            this.labelcheckoutDate = new System.Windows.Forms.Label();
            this.labelNumberOfGuests = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.textBoxResevationID = new System.Windows.Forms.TextBox();
            this.textBoxGuestID = new System.Windows.Forms.TextBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfGuests = new System.Windows.Forms.TextBox();
            this.buttonCancelBooking = new System.Windows.Forms.Button();
            this.listBoxGuestName = new System.Windows.Forms.ListBox();
            this.listBoxRoomType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerReservation = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdateRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReservationID
            // 
            this.labelReservationID.AutoSize = true;
            this.labelReservationID.Location = new System.Drawing.Point(729, 458);
            this.labelReservationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationID.Name = "labelReservationID";
            this.labelReservationID.Size = new System.Drawing.Size(81, 13);
            this.labelReservationID.TabIndex = 0;
            this.labelReservationID.Text = "Reservation ID ";
            // 
            // labelGuestID
            // 
            this.labelGuestID.AutoSize = true;
            this.labelGuestID.Location = new System.Drawing.Point(201, 273);
            this.labelGuestID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGuestID.Name = "labelGuestID";
            this.labelGuestID.Size = new System.Drawing.Size(49, 13);
            this.labelGuestID.TabIndex = 1;
            this.labelGuestID.Text = "Guest ID";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Location = new System.Drawing.Point(532, 273);
            this.labelRoomID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(52, 13);
            this.labelRoomID.TabIndex = 2;
            this.labelRoomID.Text = "Room ID ";
            // 
            // labelReservationDate
            // 
            this.labelReservationDate.AutoSize = true;
            this.labelReservationDate.Location = new System.Drawing.Point(76, 366);
            this.labelReservationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationDate.Name = "labelReservationDate";
            this.labelReservationDate.Size = new System.Drawing.Size(93, 13);
            this.labelReservationDate.TabIndex = 3;
            this.labelReservationDate.Text = "Reservation Date ";
            // 
            // labelCheckindate
            // 
            this.labelCheckindate.AutoSize = true;
            this.labelCheckindate.Location = new System.Drawing.Point(332, 366);
            this.labelCheckindate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCheckindate.Name = "labelCheckindate";
            this.labelCheckindate.Size = new System.Drawing.Size(75, 13);
            this.labelCheckindate.TabIndex = 4;
            this.labelCheckindate.Text = "Check in Date";
            // 
            // labelcheckoutDate
            // 
            this.labelcheckoutDate.AutoSize = true;
            this.labelcheckoutDate.Location = new System.Drawing.Point(590, 366);
            this.labelcheckoutDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcheckoutDate.Name = "labelcheckoutDate";
            this.labelcheckoutDate.Size = new System.Drawing.Size(82, 13);
            this.labelcheckoutDate.TabIndex = 5;
            this.labelcheckoutDate.Text = "Check out Date";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.AutoSize = true;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(356, 318);
            this.labelNumberOfGuests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(90, 13);
            this.labelNumberOfGuests.TabIndex = 6;
            this.labelNumberOfGuests.Text = "Number of guests";
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewReservations.Location = new System.Drawing.Point(19, 484);
            this.dataGridViewReservations.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.Size = new System.Drawing.Size(888, 152);
            this.dataGridViewReservations.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 458);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "All Reservations";
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(221, 439);
            this.buttonBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(101, 23);
            this.buttonBook.TabIndex = 11;
            this.buttonBook.Text = "Book Room";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // textBoxResevationID
            // 
            this.textBoxResevationID.Location = new System.Drawing.Point(827, 456);
            this.textBoxResevationID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxResevationID.Name = "textBoxResevationID";
            this.textBoxResevationID.ReadOnly = true;
            this.textBoxResevationID.Size = new System.Drawing.Size(76, 20);
            this.textBoxResevationID.TabIndex = 13;
            // 
            // textBoxGuestID
            // 
            this.textBoxGuestID.Location = new System.Drawing.Point(262, 273);
            this.textBoxGuestID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxGuestID.Name = "textBoxGuestID";
            this.textBoxGuestID.ReadOnly = true;
            this.textBoxGuestID.Size = new System.Drawing.Size(76, 20);
            this.textBoxGuestID.TabIndex = 14;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(602, 270);
            this.textBoxRoomID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.ReadOnly = true;
            this.textBoxRoomID.Size = new System.Drawing.Size(76, 20);
            this.textBoxRoomID.TabIndex = 15;
            // 
            // textBoxNumberOfGuests
            // 
            this.textBoxNumberOfGuests.Location = new System.Drawing.Point(458, 315);
            this.textBoxNumberOfGuests.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNumberOfGuests.Name = "textBoxNumberOfGuests";
            this.textBoxNumberOfGuests.Size = new System.Drawing.Size(76, 20);
            this.textBoxNumberOfGuests.TabIndex = 17;
            // 
            // buttonCancelBooking
            // 
            this.buttonCancelBooking.Location = new System.Drawing.Point(574, 439);
            this.buttonCancelBooking.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancelBooking.Name = "buttonCancelBooking";
            this.buttonCancelBooking.Size = new System.Drawing.Size(96, 23);
            this.buttonCancelBooking.TabIndex = 20;
            this.buttonCancelBooking.Text = "Delete Book";
            this.buttonCancelBooking.UseVisualStyleBackColor = true;
            // 
            // listBoxGuestName
            // 
            this.listBoxGuestName.FormattingEnabled = true;
            this.listBoxGuestName.Location = new System.Drawing.Point(188, 37);
            this.listBoxGuestName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxGuestName.Name = "listBoxGuestName";
            this.listBoxGuestName.Size = new System.Drawing.Size(196, 212);
            this.listBoxGuestName.TabIndex = 21;
            // 
            // listBoxRoomType
            // 
            this.listBoxRoomType.FormattingEnabled = true;
            this.listBoxRoomType.Location = new System.Drawing.Point(505, 37);
            this.listBoxRoomType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxRoomType.Name = "listBoxRoomType";
            this.listBoxRoomType.Size = new System.Drawing.Size(198, 212);
            this.listBoxRoomType.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Guest Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Select Room Type";
            // 
            // dateTimePickerReservation
            // 
            this.dateTimePickerReservation.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReservation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReservation.Location = new System.Drawing.Point(171, 366);
            this.dateTimePickerReservation.Name = "dateTimePickerReservation";
            this.dateTimePickerReservation.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerReservation.TabIndex = 26;
            // 
            // dateTimePickerCheckin
            // 
            this.dateTimePickerCheckin.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCheckin.Location = new System.Drawing.Point(427, 366);
            this.dateTimePickerCheckin.Name = "dateTimePickerCheckin";
            this.dateTimePickerCheckin.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerCheckin.TabIndex = 27;
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(684, 366);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerCheckOut.TabIndex = 28;
            // 
            // buttonUpdateRoom
            // 
            this.buttonUpdateRoom.Location = new System.Drawing.Point(416, 439);
            this.buttonUpdateRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonUpdateRoom.Name = "buttonUpdateRoom";
            this.buttonUpdateRoom.Size = new System.Drawing.Size(101, 23);
            this.buttonUpdateRoom.TabIndex = 29;
            this.buttonUpdateRoom.Text = "Update Book";
            this.buttonUpdateRoom.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 690);
            this.Controls.Add(this.buttonUpdateRoom);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckin);
            this.Controls.Add(this.dateTimePickerReservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRoomType);
            this.Controls.Add(this.listBoxGuestName);
            this.Controls.Add(this.buttonCancelBooking);
            this.Controls.Add(this.textBoxNumberOfGuests);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.textBoxGuestID);
            this.Controls.Add(this.textBoxResevationID);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.labelNumberOfGuests);
            this.Controls.Add(this.labelcheckoutDate);
            this.Controls.Add(this.labelCheckindate);
            this.Controls.Add(this.labelReservationDate);
            this.Controls.Add(this.labelRoomID);
            this.Controls.Add(this.labelGuestID);
            this.Controls.Add(this.labelReservationID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ReservationForm";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReservationID;
        private System.Windows.Forms.Label labelGuestID;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.Label labelReservationDate;
        private System.Windows.Forms.Label labelCheckindate;
        private System.Windows.Forms.Label labelcheckoutDate;
        private System.Windows.Forms.Label labelNumberOfGuests;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.TextBox textBoxResevationID;
        private System.Windows.Forms.TextBox textBoxGuestID;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.TextBox textBoxNumberOfGuests;
        private System.Windows.Forms.Button buttonCancelBooking;
        private System.Windows.Forms.ListBox listBoxGuestName;
        private System.Windows.Forms.ListBox listBoxRoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservation;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckin;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.Button buttonUpdateRoom;
    }
}