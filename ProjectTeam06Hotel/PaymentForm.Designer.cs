namespace ProjectTeam06Hotel
{
    partial class PaymentForm
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
            this.labelPaymentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelReservationID = new System.Windows.Forms.Label();
            this.labelGuestID = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelPayType = new System.Windows.Forms.Label();
            this.textBoxPaymentID = new System.Windows.Forms.TextBox();
            this.textBoxReservationID = new System.Windows.Forms.TextBox();
            this.textBoxGuestID = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPayType = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.labelAllPayments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPaymentID
            // 
            this.labelPaymentID.AutoSize = true;
            this.labelPaymentID.Location = new System.Drawing.Point(22, 30);
            this.labelPaymentID.Name = "labelPaymentID";
            this.labelPaymentID.Size = new System.Drawing.Size(80, 17);
            this.labelPaymentID.TabIndex = 0;
            this.labelPaymentID.Text = "Payment ID";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            // 
            // labelReservationID
            // 
            this.labelReservationID.AutoSize = true;
            this.labelReservationID.Location = new System.Drawing.Point(22, 78);
            this.labelReservationID.Name = "labelReservationID";
            this.labelReservationID.Size = new System.Drawing.Size(101, 17);
            this.labelReservationID.TabIndex = 2;
            this.labelReservationID.Text = "Reservation ID";
            // 
            // labelGuestID
            // 
            this.labelGuestID.AutoSize = true;
            this.labelGuestID.Location = new System.Drawing.Point(326, 78);
            this.labelGuestID.Name = "labelGuestID";
            this.labelGuestID.Size = new System.Drawing.Size(63, 17);
            this.labelGuestID.TabIndex = 3;
            this.labelGuestID.Text = "Guest ID";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(25, 126);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(56, 17);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount";
            // 
            // labelPayType
            // 
            this.labelPayType.AutoSize = true;
            this.labelPayType.Location = new System.Drawing.Point(326, 123);
            this.labelPayType.Name = "labelPayType";
            this.labelPayType.Size = new System.Drawing.Size(99, 17);
            this.labelPayType.TabIndex = 6;
            this.labelPayType.Text = "Payment Type";
            // 
            // textBoxPaymentID
            // 
            this.textBoxPaymentID.Location = new System.Drawing.Point(158, 24);
            this.textBoxPaymentID.Name = "textBoxPaymentID";
            this.textBoxPaymentID.ReadOnly = true;
            this.textBoxPaymentID.Size = new System.Drawing.Size(100, 22);
            this.textBoxPaymentID.TabIndex = 7;
            // 
            // textBoxReservationID
            // 
            this.textBoxReservationID.Location = new System.Drawing.Point(158, 78);
            this.textBoxReservationID.Name = "textBoxReservationID";
            this.textBoxReservationID.ReadOnly = true;
            this.textBoxReservationID.Size = new System.Drawing.Size(100, 22);
            this.textBoxReservationID.TabIndex = 8;
            // 
            // textBoxGuestID
            // 
            this.textBoxGuestID.Location = new System.Drawing.Point(435, 73);
            this.textBoxGuestID.Name = "textBoxGuestID";
            this.textBoxGuestID.ReadOnly = true;
            this.textBoxGuestID.Size = new System.Drawing.Size(100, 22);
            this.textBoxGuestID.TabIndex = 9;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(158, 120);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmount.TabIndex = 10;
            // 
            // textBoxPayType
            // 
            this.textBoxPayType.Location = new System.Drawing.Point(435, 123);
            this.textBoxPayType.Name = "textBoxPayType";
            this.textBoxPayType.ReadOnly = true;
            this.textBoxPayType.Size = new System.Drawing.Size(100, 22);
            this.textBoxPayType.TabIndex = 11;
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(256, 168);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(77, 29);
            this.buttonPay.TabIndex = 12;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(28, 251);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowHeadersWidth = 51;
            this.dataGridViewPayments.RowTemplate.Height = 24;
            this.dataGridViewPayments.Size = new System.Drawing.Size(520, 150);
            this.dataGridViewPayments.TabIndex = 13;
            // 
            // labelAllPayments
            // 
            this.labelAllPayments.AutoSize = true;
            this.labelAllPayments.Location = new System.Drawing.Point(28, 213);
            this.labelAllPayments.Name = "labelAllPayments";
            this.labelAllPayments.Size = new System.Drawing.Size(89, 17);
            this.labelAllPayments.TabIndex = 14;
            this.labelAllPayments.Text = "All Payments";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.labelAllPayments);
            this.Controls.Add(this.dataGridViewPayments);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxPayType);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxGuestID);
            this.Controls.Add(this.textBoxReservationID);
            this.Controls.Add(this.textBoxPaymentID);
            this.Controls.Add(this.labelPayType);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelGuestID);
            this.Controls.Add(this.labelReservationID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPaymentID);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaymentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelReservationID;
        private System.Windows.Forms.Label labelGuestID;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelPayType;
        private System.Windows.Forms.TextBox textBoxPaymentID;
        private System.Windows.Forms.TextBox textBoxReservationID;
        private System.Windows.Forms.TextBox textBoxGuestID;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPayType;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Label labelAllPayments;
    }
}