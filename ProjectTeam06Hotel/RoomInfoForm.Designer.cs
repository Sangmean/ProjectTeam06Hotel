namespace ProjectTeam06Hotel
{
    partial class RoomInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTxtRoomInfo = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRoomTypeDelete = new System.Windows.Forms.Button();
            this.buttonRoomTypeUpdate = new System.Windows.Forms.Button();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonRoomTypeAdd = new System.Windows.Forms.Button();
            this.textBoxPricePerNight = new System.Windows.Forms.TextBox();
            this.labelRoomPrice = new System.Windows.Forms.Label();
            this.textBoxAddRoomType = new System.Windows.Forms.TextBox();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.buttonBackupDatabase = new System.Windows.Forms.Button();
            this.dataGridViewAddRoom = new System.Windows.Forms.DataGridView();
            this.buttonRoomAdd = new System.Windows.Forms.Button();
            this.buttonRoomDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTxtRoomInfo
            // 
            this.labelTxtRoomInfo.AutoSize = true;
            this.labelTxtRoomInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTxtRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTxtRoomInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTxtRoomInfo.Location = new System.Drawing.Point(72, 75);
            this.labelTxtRoomInfo.Name = "labelTxtRoomInfo";
            this.labelTxtRoomInfo.Size = new System.Drawing.Size(108, 15);
            this.labelTxtRoomInfo.TabIndex = 8;
            this.labelTxtRoomInfo.Text = "Room Information";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewRoom.Location = new System.Drawing.Point(32, 111);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowHeadersWidth = 62;
            this.dataGridViewRoom.Size = new System.Drawing.Size(478, 102);
            this.dataGridViewRoom.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRoomTypeDelete);
            this.groupBox1.Controls.Add(this.buttonRoomTypeUpdate);
            this.groupBox1.Controls.Add(this.listBoxStatus);
            this.groupBox1.Controls.Add(this.textBoxCapacity);
            this.groupBox1.Controls.Add(this.labelCapacity);
            this.groupBox1.Controls.Add(this.dataGridViewRoom);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.buttonRoomTypeAdd);
            this.groupBox1.Controls.Add(this.textBoxPricePerNight);
            this.groupBox1.Controls.Add(this.labelRoomPrice);
            this.groupBox1.Controls.Add(this.textBoxAddRoomType);
            this.groupBox1.Controls.Add(this.labelRoomName);
            this.groupBox1.Location = new System.Drawing.Point(72, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 270);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Information";
            // 
            // buttonRoomTypeDelete
            // 
            this.buttonRoomTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomTypeDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomTypeDelete.Location = new System.Drawing.Point(435, 233);
            this.buttonRoomTypeDelete.Name = "buttonRoomTypeDelete";
            this.buttonRoomTypeDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomTypeDelete.TabIndex = 11;
            this.buttonRoomTypeDelete.Text = "Delete";
            this.buttonRoomTypeDelete.UseVisualStyleBackColor = true;
            // 
            // buttonRoomTypeUpdate
            // 
            this.buttonRoomTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomTypeUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomTypeUpdate.Location = new System.Drawing.Point(232, 233);
            this.buttonRoomTypeUpdate.Name = "buttonRoomTypeUpdate";
            this.buttonRoomTypeUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomTypeUpdate.TabIndex = 10;
            this.buttonRoomTypeUpdate.Text = "Update";
            this.buttonRoomTypeUpdate.UseVisualStyleBackColor = true;
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.Items.AddRange(new object[] {
            "Occupied",
            "Vacant"});
            this.listBoxStatus.Location = new System.Drawing.Point(342, 33);
            this.listBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(127, 30);
            this.listBoxStatus.TabIndex = 9;
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(342, 72);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(127, 20);
            this.textBoxCapacity.TabIndex = 8;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCapacity.Location = new System.Drawing.Point(269, 72);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(48, 13);
            this.labelCapacity.TabIndex = 6;
            this.labelCapacity.Text = "Capacity";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStatus.Location = new System.Drawing.Point(269, 35);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status";
            // 
            // buttonRoomTypeAdd
            // 
            this.buttonRoomTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomTypeAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomTypeAdd.Location = new System.Drawing.Point(32, 233);
            this.buttonRoomTypeAdd.Name = "buttonRoomTypeAdd";
            this.buttonRoomTypeAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomTypeAdd.TabIndex = 4;
            this.buttonRoomTypeAdd.Text = "Add";
            this.buttonRoomTypeAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxPricePerNight
            // 
            this.textBoxPricePerNight.Location = new System.Drawing.Point(79, 72);
            this.textBoxPricePerNight.Name = "textBoxPricePerNight";
            this.textBoxPricePerNight.Size = new System.Drawing.Size(127, 20);
            this.textBoxPricePerNight.TabIndex = 3;
            // 
            // labelRoomPrice
            // 
            this.labelRoomPrice.AutoSize = true;
            this.labelRoomPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRoomPrice.Location = new System.Drawing.Point(12, 76);
            this.labelRoomPrice.Name = "labelRoomPrice";
            this.labelRoomPrice.Size = new System.Drawing.Size(62, 13);
            this.labelRoomPrice.TabIndex = 2;
            this.labelRoomPrice.Text = "Room Price";
            // 
            // textBoxAddRoomType
            // 
            this.textBoxAddRoomType.Location = new System.Drawing.Point(79, 33);
            this.textBoxAddRoomType.Name = "textBoxAddRoomType";
            this.textBoxAddRoomType.Size = new System.Drawing.Size(127, 20);
            this.textBoxAddRoomType.TabIndex = 1;
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRoomName.Location = new System.Drawing.Point(13, 33);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(62, 13);
            this.labelRoomName.TabIndex = 0;
            this.labelRoomName.Text = "Room Type";
            // 
            // buttonBackupDatabase
            // 
            this.buttonBackupDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackupDatabase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBackupDatabase.Location = new System.Drawing.Point(414, 493);
            this.buttonBackupDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBackupDatabase.Name = "buttonBackupDatabase";
            this.buttonBackupDatabase.Size = new System.Drawing.Size(89, 36);
            this.buttonBackupDatabase.TabIndex = 12;
            this.buttonBackupDatabase.Text = "Backup\r\nDatabase\r\n\r\n";
            this.buttonBackupDatabase.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAddRoom
            // 
            this.dataGridViewAddRoom.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewAddRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddRoom.Location = new System.Drawing.Point(72, 448);
            this.dataGridViewAddRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAddRoom.Name = "dataGridViewAddRoom";
            this.dataGridViewAddRoom.RowHeadersWidth = 62;
            this.dataGridViewAddRoom.RowTemplate.Height = 28;
            this.dataGridViewAddRoom.Size = new System.Drawing.Size(233, 100);
            this.dataGridViewAddRoom.TabIndex = 13;
            // 
            // buttonRoomAdd
            // 
            this.buttonRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomAdd.Location = new System.Drawing.Point(70, 560);
            this.buttonRoomAdd.Name = "buttonRoomAdd";
            this.buttonRoomAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomAdd.TabIndex = 12;
            this.buttonRoomAdd.Text = "Add";
            this.buttonRoomAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRoomDelete
            // 
            this.buttonRoomDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomDelete.Location = new System.Drawing.Point(230, 560);
            this.buttonRoomDelete.Name = "buttonRoomDelete";
            this.buttonRoomDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonRoomDelete.TabIndex = 14;
            this.buttonRoomDelete.Text = "Delete";
            this.buttonRoomDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(75, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rooms";
            // 
            // RoomInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(666, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRoomDelete);
            this.Controls.Add(this.buttonRoomAdd);
            this.Controls.Add(this.dataGridViewAddRoom);
            this.Controls.Add(this.buttonBackupDatabase);
            this.Controls.Add(this.labelTxtRoomInfo);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "RoomInfoForm";
            this.Text = "Room Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTxtRoomInfo;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRoomTypeAdd;
        private System.Windows.Forms.TextBox textBoxPricePerNight;
        private System.Windows.Forms.Label labelRoomPrice;
        private System.Windows.Forms.TextBox textBoxAddRoomType;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Button buttonRoomTypeUpdate;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Button buttonRoomTypeDelete;
        private System.Windows.Forms.Button buttonBackupDatabase;
        private System.Windows.Forms.DataGridView dataGridViewAddRoom;
        private System.Windows.Forms.Button buttonRoomAdd;
        private System.Windows.Forms.Button buttonRoomDelete;
        private System.Windows.Forms.Label label1;
    }
}