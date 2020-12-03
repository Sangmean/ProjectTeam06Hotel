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
            this.label2 = new System.Windows.Forms.Label();
            this.labelPayType = new System.Windows.Forms.Label();
            this.textBoxPayType = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.labelAllPayments = new System.Windows.Forms.Label();
            this.dataGridViewReservationInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfNight = new System.Windows.Forms.TextBox();
            this.textBoxPricePerNight = new System.Windows.Forms.TextBox();
            this.buttonPayUpdate = new System.Windows.Forms.Button();
            this.buttonPayDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservationInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 5;
            // 
            // labelPayType
            // 
            this.labelPayType.AutoSize = true;
            this.labelPayType.Location = new System.Drawing.Point(22, 69);
            this.labelPayType.Name = "labelPayType";
            this.labelPayType.Size = new System.Drawing.Size(109, 20);
            this.labelPayType.TabIndex = 6;
            this.labelPayType.Text = "Payment Type";
            // 
            // textBoxPayType
            // 
            this.textBoxPayType.Location = new System.Drawing.Point(160, 69);
            this.textBoxPayType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxPayType.Name = "textBoxPayType";
            this.textBoxPayType.Size = new System.Drawing.Size(112, 26);
            this.textBoxPayType.TabIndex = 11;
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(26, 134);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(87, 35);
            this.buttonPay.TabIndex = 12;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(39, 669);
            this.dataGridViewPayments.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowHeadersWidth = 51;
            this.dataGridViewPayments.RowTemplate.Height = 24;
            this.dataGridViewPayments.Size = new System.Drawing.Size(1054, 254);
            this.dataGridViewPayments.TabIndex = 13;
            // 
            // labelAllPayments
            // 
            this.labelAllPayments.AutoSize = true;
            this.labelAllPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAllPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAllPayments.Location = new System.Drawing.Point(42, 625);
            this.labelAllPayments.Name = "labelAllPayments";
            this.labelAllPayments.Size = new System.Drawing.Size(121, 22);
            this.labelAllPayments.TabIndex = 14;
            this.labelAllPayments.Text = "All Payments";
            // 
            // dataGridViewReservationInfo
            // 
            this.dataGridViewReservationInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservationInfo.Location = new System.Drawing.Point(39, 82);
            this.dataGridViewReservationInfo.Name = "dataGridViewReservationInfo";
            this.dataGridViewReservationInfo.RowHeadersWidth = 62;
            this.dataGridViewReservationInfo.RowTemplate.Height = 28;
            this.dataGridViewReservationInfo.Size = new System.Drawing.Size(1054, 235);
            this.dataGridViewReservationInfo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "All Reservation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPayDelete);
            this.groupBox1.Controls.Add(this.buttonPayUpdate);
            this.groupBox1.Controls.Add(this.labelPayType);
            this.groupBox1.Controls.Add(this.textBoxPayType);
            this.groupBox1.Controls.Add(this.buttonPay);
            this.groupBox1.Location = new System.Drawing.Point(548, 388);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(427, 200);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.textBoxPricePerNight);
            this.groupBox2.Controls.Add(this.textBoxNumberOfNight);
            this.groupBox2.Controls.Add(this.textBoxTotalAmount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxLastName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxFirstName);
            this.groupBox2.Location = new System.Drawing.Point(153, 342);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(316, 280);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Billing Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Location = new System.Drawing.Point(160, 84);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(112, 19);
            this.textBoxLastName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(160, 47);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(112, 19);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number Of Night";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price Per Night";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Amount";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalAmount.Location = new System.Drawing.Point(160, 213);
            this.textBoxTotalAmount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(112, 19);
            this.textBoxTotalAmount.TabIndex = 17;
            // 
            // textBoxNumberOfNight
            // 
            this.textBoxNumberOfNight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNumberOfNight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberOfNight.Location = new System.Drawing.Point(160, 125);
            this.textBoxNumberOfNight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxNumberOfNight.Name = "textBoxNumberOfNight";
            this.textBoxNumberOfNight.Size = new System.Drawing.Size(112, 19);
            this.textBoxNumberOfNight.TabIndex = 17;
            // 
            // textBoxPricePerNight
            // 
            this.textBoxPricePerNight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPricePerNight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPricePerNight.Location = new System.Drawing.Point(160, 168);
            this.textBoxPricePerNight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxPricePerNight.Name = "textBoxPricePerNight";
            this.textBoxPricePerNight.Size = new System.Drawing.Size(112, 19);
            this.textBoxPricePerNight.TabIndex = 18;
            // 
            // buttonPayUpdate
            // 
            this.buttonPayUpdate.Location = new System.Drawing.Point(160, 134);
            this.buttonPayUpdate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonPayUpdate.Name = "buttonPayUpdate";
            this.buttonPayUpdate.Size = new System.Drawing.Size(87, 35);
            this.buttonPayUpdate.TabIndex = 13;
            this.buttonPayUpdate.Text = "Update";
            this.buttonPayUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonPayDelete
            // 
            this.buttonPayDelete.Location = new System.Drawing.Point(295, 134);
            this.buttonPayDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonPayDelete.Name = "buttonPayDelete";
            this.buttonPayDelete.Size = new System.Drawing.Size(87, 35);
            this.buttonPayDelete.TabIndex = 14;
            this.buttonPayDelete.Text = "Delete";
            this.buttonPayDelete.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 1008);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReservationInfo);
            this.Controls.Add(this.labelAllPayments);
            this.Controls.Add(this.dataGridViewPayments);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservationInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPayType;
        private System.Windows.Forms.TextBox textBoxPayType;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Label labelAllPayments;
        private System.Windows.Forms.DataGridView dataGridViewReservationInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPricePerNight;
        private System.Windows.Forms.TextBox textBoxNumberOfNight;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonPayDelete;
        private System.Windows.Forms.Button buttonPayUpdate;
    }
}