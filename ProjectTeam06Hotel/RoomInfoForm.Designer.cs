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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelTxtRoomInfo.Location = new System.Drawing.Point(108, 115);
            this.labelTxtRoomInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTxtRoomInfo.Name = "labelTxtRoomInfo";
            this.labelTxtRoomInfo.Size = new System.Drawing.Size(159, 22);
            this.labelTxtRoomInfo.TabIndex = 8;
            this.labelTxtRoomInfo.Text = "Room Information";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewRoom.Location = new System.Drawing.Point(156, 405);
            this.dataGridViewRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowHeadersWidth = 62;
            this.dataGridViewRoom.Size = new System.Drawing.Size(717, 157);
            this.dataGridViewRoom.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRoomTypeDelete);
            this.groupBox1.Controls.Add(this.buttonRoomTypeUpdate);
            this.groupBox1.Controls.Add(this.listBoxStatus);
            this.groupBox1.Controls.Add(this.textBoxCapacity);
            this.groupBox1.Controls.Add(this.labelCapacity);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.buttonRoomTypeAdd);
            this.groupBox1.Controls.Add(this.textBoxPricePerNight);
            this.groupBox1.Controls.Add(this.labelRoomPrice);
            this.groupBox1.Controls.Add(this.textBoxAddRoomType);
            this.groupBox1.Controls.Add(this.labelRoomName);
            this.groupBox1.Location = new System.Drawing.Point(108, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(836, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Information";
            // 
            // buttonRoomTypeDelete
            // 
            this.buttonRoomTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomTypeDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomTypeDelete.Location = new System.Drawing.Point(575, 170);
            this.buttonRoomTypeDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRoomTypeDelete.Name = "buttonRoomTypeDelete";
            this.buttonRoomTypeDelete.Size = new System.Drawing.Size(112, 35);
            this.buttonRoomTypeDelete.TabIndex = 11;
            this.buttonRoomTypeDelete.Text = "Delete";
            this.buttonRoomTypeDelete.UseVisualStyleBackColor = true;
            // 
            // buttonRoomTypeUpdate
            // 
            this.buttonRoomTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomTypeUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomTypeUpdate.Location = new System.Drawing.Point(330, 170);
            this.buttonRoomTypeUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRoomTypeUpdate.Name = "buttonRoomTypeUpdate";
            this.buttonRoomTypeUpdate.Size = new System.Drawing.Size(112, 35);
            this.buttonRoomTypeUpdate.TabIndex = 10;
            this.buttonRoomTypeUpdate.Text = "Update";
            this.buttonRoomTypeUpdate.UseVisualStyleBackColor = true;
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 20;
            this.listBoxStatus.Items.AddRange(new object[] {
            "Occupied",
            "Vacant"});
            this.listBoxStatus.Location = new System.Drawing.Point(513, 51);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(188, 44);
            this.listBoxStatus.TabIndex = 9;
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(513, 111);
            this.textBoxCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(188, 26);
            this.textBoxCapacity.TabIndex = 8;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCapacity.Location = new System.Drawing.Point(404, 111);
            this.labelCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(70, 20);
            this.labelCapacity.TabIndex = 6;
            this.labelCapacity.Text = "Capacity";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStatus.Location = new System.Drawing.Point(404, 54);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status";
            // 
            // buttonRoomTypeAdd
            // 
            this.buttonRoomTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomTypeAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomTypeAdd.Location = new System.Drawing.Point(92, 170);
            this.buttonRoomTypeAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRoomTypeAdd.Name = "buttonRoomTypeAdd";
            this.buttonRoomTypeAdd.Size = new System.Drawing.Size(112, 35);
            this.buttonRoomTypeAdd.TabIndex = 4;
            this.buttonRoomTypeAdd.Text = "Add";
            this.buttonRoomTypeAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxPricePerNight
            // 
            this.textBoxPricePerNight.Location = new System.Drawing.Point(118, 111);
            this.textBoxPricePerNight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPricePerNight.Name = "textBoxPricePerNight";
            this.textBoxPricePerNight.Size = new System.Drawing.Size(188, 26);
            this.textBoxPricePerNight.TabIndex = 3;
            // 
            // labelRoomPrice
            // 
            this.labelRoomPrice.AutoSize = true;
            this.labelRoomPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRoomPrice.Location = new System.Drawing.Point(18, 117);
            this.labelRoomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomPrice.Name = "labelRoomPrice";
            this.labelRoomPrice.Size = new System.Drawing.Size(91, 20);
            this.labelRoomPrice.TabIndex = 2;
            this.labelRoomPrice.Text = "Room Price";
            // 
            // textBoxAddRoomType
            // 
            this.textBoxAddRoomType.Location = new System.Drawing.Point(118, 51);
            this.textBoxAddRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddRoomType.Name = "textBoxAddRoomType";
            this.textBoxAddRoomType.Size = new System.Drawing.Size(188, 26);
            this.textBoxAddRoomType.TabIndex = 1;
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRoomName.Location = new System.Drawing.Point(19, 51);
            this.labelRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(90, 20);
            this.labelRoomName.TabIndex = 0;
            this.labelRoomName.Text = "Room Type";
            // 
            // buttonBackupDatabase
            // 
            this.buttonBackupDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackupDatabase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBackupDatabase.Location = new System.Drawing.Point(880, 452);
            this.buttonBackupDatabase.Name = "buttonBackupDatabase";
            this.buttonBackupDatabase.Size = new System.Drawing.Size(133, 56);
            this.buttonBackupDatabase.TabIndex = 12;
            this.buttonBackupDatabase.Text = "Backup\r\nDatabase\r\n\r\n";
            this.buttonBackupDatabase.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAddRoom
            // 
            this.dataGridViewAddRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddRoom.Location = new System.Drawing.Point(156, 685);
            this.dataGridViewAddRoom.Name = "dataGridViewAddRoom";
            this.dataGridViewAddRoom.RowHeadersWidth = 62;
            this.dataGridViewAddRoom.RowTemplate.Height = 28;
            this.dataGridViewAddRoom.Size = new System.Drawing.Size(857, 157);
            this.dataGridViewAddRoom.TabIndex = 13;
            // 
            // buttonRoomAdd
            // 
            this.buttonRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRoomAdd.Location = new System.Drawing.Point(156, 872);
            this.buttonRoomAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRoomAdd.Name = "buttonRoomAdd";
            this.buttonRoomAdd.Size = new System.Drawing.Size(112, 35);
            this.buttonRoomAdd.TabIndex = 12;
            this.buttonRoomAdd.Text = "Add";
            this.buttonRoomAdd.UseVisualStyleBackColor = true;
            // 
            // RoomInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1196, 1001);
            this.Controls.Add(this.buttonRoomAdd);
            this.Controls.Add(this.dataGridViewAddRoom);
            this.Controls.Add(this.buttonBackupDatabase);
            this.Controls.Add(this.labelTxtRoomInfo);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}