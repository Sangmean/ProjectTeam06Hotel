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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.textBoxResevationID = new System.Windows.Forms.TextBox();
            this.textBoxGuestID = new System.Windows.Forms.TextBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.textBoxReservationDate = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfGuests = new System.Windows.Forms.TextBox();
            this.textBoxCheckinDate = new System.Windows.Forms.TextBox();
            this.textBoxCheckoutDate = new System.Windows.Forms.TextBox();
            this.buttonCancelBooking = new System.Windows.Forms.Button();
            this.listBoxGuestName = new System.Windows.Forms.ListBox();
            this.listBoxRoomType = new System.Windows.Forms.ListBox();
            this.checkBoxPay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReservationID
            // 
            this.labelReservationID.AutoSize = true;
            this.labelReservationID.Location = new System.Drawing.Point(20, 386);
            this.labelReservationID.Name = "labelReservationID";
            this.labelReservationID.Size = new System.Drawing.Size(105, 17);
            this.labelReservationID.TabIndex = 0;
            this.labelReservationID.Text = "Reservation ID ";
            // 
            // labelGuestID
            // 
            this.labelGuestID.AutoSize = true;
            this.labelGuestID.Location = new System.Drawing.Point(23, 332);
            this.labelGuestID.Name = "labelGuestID";
            this.labelGuestID.Size = new System.Drawing.Size(63, 17);
            this.labelGuestID.TabIndex = 1;
            this.labelGuestID.Text = "Guest ID";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Location = new System.Drawing.Point(348, 327);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(66, 17);
            this.labelRoomID.TabIndex = 2;
            this.labelRoomID.Text = "Room ID ";
            // 
            // labelReservationDate
            // 
            this.labelReservationDate.AutoSize = true;
            this.labelReservationDate.Location = new System.Drawing.Point(296, 384);
            this.labelReservationDate.Name = "labelReservationDate";
            this.labelReservationDate.Size = new System.Drawing.Size(122, 17);
            this.labelReservationDate.TabIndex = 3;
            this.labelReservationDate.Text = "Reservation Date ";
            // 
            // labelCheckindate
            // 
            this.labelCheckindate.AutoSize = true;
            this.labelCheckindate.Location = new System.Drawing.Point(23, 451);
            this.labelCheckindate.Name = "labelCheckindate";
            this.labelCheckindate.Size = new System.Drawing.Size(96, 17);
            this.labelCheckindate.TabIndex = 4;
            this.labelCheckindate.Text = "Check in Date";
            // 
            // labelcheckoutDate
            // 
            this.labelcheckoutDate.AutoSize = true;
            this.labelcheckoutDate.Location = new System.Drawing.Point(366, 451);
            this.labelcheckoutDate.Name = "labelcheckoutDate";
            this.labelcheckoutDate.Size = new System.Drawing.Size(105, 17);
            this.labelcheckoutDate.TabIndex = 5;
            this.labelcheckoutDate.Text = "Check out Date";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.AutoSize = true;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(543, 380);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(120, 17);
            this.labelNumberOfGuests.TabIndex = 6;
            this.labelNumberOfGuests.Text = "Number of guests";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Reservation Form";
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(26, 596);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.Size = new System.Drawing.Size(752, 187);
            this.dataGridViewReservations.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "All Reservations";
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(94, 511);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(135, 28);
            this.buttonBook.TabIndex = 11;
            this.buttonBook.Text = "Book Room";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // textBoxResevationID
            // 
            this.textBoxResevationID.Location = new System.Drawing.Point(151, 383);
            this.textBoxResevationID.Name = "textBoxResevationID";
            this.textBoxResevationID.Size = new System.Drawing.Size(100, 22);
            this.textBoxResevationID.TabIndex = 13;
            // 
            // textBoxGuestID
            // 
            this.textBoxGuestID.Location = new System.Drawing.Point(151, 327);
            this.textBoxGuestID.Name = "textBoxGuestID";
            this.textBoxGuestID.Size = new System.Drawing.Size(100, 22);
            this.textBoxGuestID.TabIndex = 14;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(468, 322);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(100, 22);
            this.textBoxRoomID.TabIndex = 15;
            // 
            // textBoxReservationDate
            // 
            this.textBoxReservationDate.Location = new System.Drawing.Point(424, 380);
            this.textBoxReservationDate.Name = "textBoxReservationDate";
            this.textBoxReservationDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxReservationDate.TabIndex = 16;
            // 
            // textBoxNumberOfGuests
            // 
            this.textBoxNumberOfGuests.Location = new System.Drawing.Point(678, 377);
            this.textBoxNumberOfGuests.Name = "textBoxNumberOfGuests";
            this.textBoxNumberOfGuests.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberOfGuests.TabIndex = 17;
            // 
            // textBoxCheckinDate
            // 
            this.textBoxCheckinDate.Location = new System.Drawing.Point(149, 446);
            this.textBoxCheckinDate.Name = "textBoxCheckinDate";
            this.textBoxCheckinDate.Size = new System.Drawing.Size(149, 22);
            this.textBoxCheckinDate.TabIndex = 18;
            // 
            // textBoxCheckoutDate
            // 
            this.textBoxCheckoutDate.Location = new System.Drawing.Point(531, 448);
            this.textBoxCheckoutDate.Name = "textBoxCheckoutDate";
            this.textBoxCheckoutDate.Size = new System.Drawing.Size(153, 22);
            this.textBoxCheckoutDate.TabIndex = 19;
            // 
            // buttonCancelBooking
            // 
            this.buttonCancelBooking.Location = new System.Drawing.Point(424, 511);
            this.buttonCancelBooking.Name = "buttonCancelBooking";
            this.buttonCancelBooking.Size = new System.Drawing.Size(144, 28);
            this.buttonCancelBooking.TabIndex = 20;
            this.buttonCancelBooking.Text = "Cancel Booking";
            this.buttonCancelBooking.UseVisualStyleBackColor = true;
            // 
            // listBoxGuestName
            // 
            this.listBoxGuestName.FormattingEnabled = true;
            this.listBoxGuestName.ItemHeight = 16;
            this.listBoxGuestName.Location = new System.Drawing.Point(26, 50);
            this.listBoxGuestName.Name = "listBoxGuestName";
            this.listBoxGuestName.Size = new System.Drawing.Size(260, 260);
            this.listBoxGuestName.TabIndex = 21;
            // 
            // listBoxRoomType
            // 
            this.listBoxRoomType.FormattingEnabled = true;
            this.listBoxRoomType.ItemHeight = 16;
            this.listBoxRoomType.Location = new System.Drawing.Point(332, 47);
            this.listBoxRoomType.Name = "listBoxRoomType";
            this.listBoxRoomType.Size = new System.Drawing.Size(263, 260);
            this.listBoxRoomType.TabIndex = 22;
            // 
            // checkBoxPay
            // 
            this.checkBoxPay.AutoSize = true;
            this.checkBoxPay.Location = new System.Drawing.Point(634, 516);
            this.checkBoxPay.Name = "checkBoxPay";
            this.checkBoxPay.Size = new System.Drawing.Size(124, 21);
            this.checkBoxPay.TabIndex = 23;
            this.checkBoxPay.Text = "Payment made";
            this.checkBoxPay.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 795);
            this.Controls.Add(this.checkBoxPay);
            this.Controls.Add(this.listBoxRoomType);
            this.Controls.Add(this.listBoxGuestName);
            this.Controls.Add(this.buttonCancelBooking);
            this.Controls.Add(this.textBoxCheckoutDate);
            this.Controls.Add(this.textBoxCheckinDate);
            this.Controls.Add(this.textBoxNumberOfGuests);
            this.Controls.Add(this.textBoxReservationDate);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.textBoxGuestID);
            this.Controls.Add(this.textBoxResevationID);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelNumberOfGuests);
            this.Controls.Add(this.labelcheckoutDate);
            this.Controls.Add(this.labelCheckindate);
            this.Controls.Add(this.labelReservationDate);
            this.Controls.Add(this.labelRoomID);
            this.Controls.Add(this.labelGuestID);
            this.Controls.Add(this.labelReservationID);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.TextBox textBoxResevationID;
        private System.Windows.Forms.TextBox textBoxGuestID;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.TextBox textBoxReservationDate;
        private System.Windows.Forms.TextBox textBoxNumberOfGuests;
        private System.Windows.Forms.TextBox textBoxCheckinDate;
        private System.Windows.Forms.TextBox textBoxCheckoutDate;
        private System.Windows.Forms.Button buttonCancelBooking;
        private System.Windows.Forms.ListBox listBoxGuestName;
        private System.Windows.Forms.ListBox listBoxRoomType;
        private System.Windows.Forms.CheckBox checkBoxPay;
    }
}