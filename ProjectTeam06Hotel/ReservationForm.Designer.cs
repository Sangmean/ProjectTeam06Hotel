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
            this.textBoxReservationDate = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfGuests = new System.Windows.Forms.TextBox();
            this.textBoxCheckinDate = new System.Windows.Forms.TextBox();
            this.textBoxCheckoutDate = new System.Windows.Forms.TextBox();
            this.buttonCancelBooking = new System.Windows.Forms.Button();
            this.listBoxGuestName = new System.Windows.Forms.ListBox();
            this.listBoxRoomType = new System.Windows.Forms.ListBox();
            this.checkBoxPay = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReservationID
            // 
            this.labelReservationID.AutoSize = true;
            this.labelReservationID.Location = new System.Drawing.Point(22, 482);
            this.labelReservationID.Name = "labelReservationID";
            this.labelReservationID.Size = new System.Drawing.Size(119, 20);
            this.labelReservationID.TabIndex = 0;
            this.labelReservationID.Text = "Reservation ID ";
            // 
            // labelGuestID
            // 
            this.labelGuestID.AutoSize = true;
            this.labelGuestID.Location = new System.Drawing.Point(26, 415);
            this.labelGuestID.Name = "labelGuestID";
            this.labelGuestID.Size = new System.Drawing.Size(74, 20);
            this.labelGuestID.TabIndex = 1;
            this.labelGuestID.Text = "Guest ID";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Location = new System.Drawing.Point(392, 409);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(77, 20);
            this.labelRoomID.TabIndex = 2;
            this.labelRoomID.Text = "Room ID ";
            // 
            // labelReservationDate
            // 
            this.labelReservationDate.AutoSize = true;
            this.labelReservationDate.Location = new System.Drawing.Point(333, 480);
            this.labelReservationDate.Name = "labelReservationDate";
            this.labelReservationDate.Size = new System.Drawing.Size(137, 20);
            this.labelReservationDate.TabIndex = 3;
            this.labelReservationDate.Text = "Reservation Date ";
            // 
            // labelCheckindate
            // 
            this.labelCheckindate.AutoSize = true;
            this.labelCheckindate.Location = new System.Drawing.Point(26, 564);
            this.labelCheckindate.Name = "labelCheckindate";
            this.labelCheckindate.Size = new System.Drawing.Size(109, 20);
            this.labelCheckindate.TabIndex = 4;
            this.labelCheckindate.Text = "Check in Date";
            // 
            // labelcheckoutDate
            // 
            this.labelcheckoutDate.AutoSize = true;
            this.labelcheckoutDate.Location = new System.Drawing.Point(412, 564);
            this.labelcheckoutDate.Name = "labelcheckoutDate";
            this.labelcheckoutDate.Size = new System.Drawing.Size(120, 20);
            this.labelcheckoutDate.TabIndex = 5;
            this.labelcheckoutDate.Text = "Check out Date";
            // 
            // labelNumberOfGuests
            // 
            this.labelNumberOfGuests.AutoSize = true;
            this.labelNumberOfGuests.Location = new System.Drawing.Point(611, 475);
            this.labelNumberOfGuests.Name = "labelNumberOfGuests";
            this.labelNumberOfGuests.Size = new System.Drawing.Size(135, 20);
            this.labelNumberOfGuests.TabIndex = 6;
            this.labelNumberOfGuests.Text = "Number of guests";
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(29, 745);
            this.dataGridViewReservations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.Size = new System.Drawing.Size(846, 234);
            this.dataGridViewReservations.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 704);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "All Reservations";
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(106, 639);
            this.buttonBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(152, 35);
            this.buttonBook.TabIndex = 11;
            this.buttonBook.Text = "Book Room";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // textBoxResevationID
            // 
            this.textBoxResevationID.Location = new System.Drawing.Point(170, 479);
            this.textBoxResevationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResevationID.Name = "textBoxResevationID";
            this.textBoxResevationID.Size = new System.Drawing.Size(112, 26);
            this.textBoxResevationID.TabIndex = 13;
            // 
            // textBoxGuestID
            // 
            this.textBoxGuestID.Location = new System.Drawing.Point(170, 409);
            this.textBoxGuestID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuestID.Name = "textBoxGuestID";
            this.textBoxGuestID.Size = new System.Drawing.Size(112, 26);
            this.textBoxGuestID.TabIndex = 14;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(526, 402);
            this.textBoxRoomID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(112, 26);
            this.textBoxRoomID.TabIndex = 15;
            // 
            // textBoxReservationDate
            // 
            this.textBoxReservationDate.Location = new System.Drawing.Point(477, 475);
            this.textBoxReservationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReservationDate.Name = "textBoxReservationDate";
            this.textBoxReservationDate.Size = new System.Drawing.Size(112, 26);
            this.textBoxReservationDate.TabIndex = 16;
            // 
            // textBoxNumberOfGuests
            // 
            this.textBoxNumberOfGuests.Location = new System.Drawing.Point(763, 471);
            this.textBoxNumberOfGuests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumberOfGuests.Name = "textBoxNumberOfGuests";
            this.textBoxNumberOfGuests.Size = new System.Drawing.Size(112, 26);
            this.textBoxNumberOfGuests.TabIndex = 17;
            // 
            // textBoxCheckinDate
            // 
            this.textBoxCheckinDate.Location = new System.Drawing.Point(168, 558);
            this.textBoxCheckinDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCheckinDate.Name = "textBoxCheckinDate";
            this.textBoxCheckinDate.Size = new System.Drawing.Size(167, 26);
            this.textBoxCheckinDate.TabIndex = 18;
            // 
            // textBoxCheckoutDate
            // 
            this.textBoxCheckoutDate.Location = new System.Drawing.Point(597, 560);
            this.textBoxCheckoutDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCheckoutDate.Name = "textBoxCheckoutDate";
            this.textBoxCheckoutDate.Size = new System.Drawing.Size(172, 26);
            this.textBoxCheckoutDate.TabIndex = 19;
            // 
            // buttonCancelBooking
            // 
            this.buttonCancelBooking.Location = new System.Drawing.Point(477, 639);
            this.buttonCancelBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelBooking.Name = "buttonCancelBooking";
            this.buttonCancelBooking.Size = new System.Drawing.Size(162, 35);
            this.buttonCancelBooking.TabIndex = 20;
            this.buttonCancelBooking.Text = "Cancel Booking";
            this.buttonCancelBooking.UseVisualStyleBackColor = true;
            // 
            // listBoxGuestName
            // 
            this.listBoxGuestName.FormattingEnabled = true;
            this.listBoxGuestName.ItemHeight = 20;
            this.listBoxGuestName.Location = new System.Drawing.Point(29, 62);
            this.listBoxGuestName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxGuestName.Name = "listBoxGuestName";
            this.listBoxGuestName.Size = new System.Drawing.Size(292, 324);
            this.listBoxGuestName.TabIndex = 21;
            // 
            // listBoxRoomType
            // 
            this.listBoxRoomType.FormattingEnabled = true;
            this.listBoxRoomType.ItemHeight = 20;
            this.listBoxRoomType.Location = new System.Drawing.Point(374, 59);
            this.listBoxRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxRoomType.Name = "listBoxRoomType";
            this.listBoxRoomType.Size = new System.Drawing.Size(295, 324);
            this.listBoxRoomType.TabIndex = 22;
            // 
            // checkBoxPay
            // 
            this.checkBoxPay.AutoSize = true;
            this.checkBoxPay.Location = new System.Drawing.Point(713, 645);
            this.checkBoxPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPay.Name = "checkBoxPay";
            this.checkBoxPay.Size = new System.Drawing.Size(141, 24);
            this.checkBoxPay.TabIndex = 23;
            this.checkBoxPay.Text = "Payment made";
            this.checkBoxPay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Guest Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Select Room Type";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1070);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.labelNumberOfGuests);
            this.Controls.Add(this.labelcheckoutDate);
            this.Controls.Add(this.labelCheckindate);
            this.Controls.Add(this.labelReservationDate);
            this.Controls.Add(this.labelRoomID);
            this.Controls.Add(this.labelGuestID);
            this.Controls.Add(this.labelReservationID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox textBoxReservationDate;
        private System.Windows.Forms.TextBox textBoxNumberOfGuests;
        private System.Windows.Forms.TextBox textBoxCheckinDate;
        private System.Windows.Forms.TextBox textBoxCheckoutDate;
        private System.Windows.Forms.Button buttonCancelBooking;
        private System.Windows.Forms.ListBox listBoxGuestName;
        private System.Windows.Forms.ListBox listBoxRoomType;
        private System.Windows.Forms.CheckBox checkBoxPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}