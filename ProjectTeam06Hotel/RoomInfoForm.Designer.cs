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
            this.labelTxtRoomInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.txtBoxUpdatePrice = new System.Windows.Forms.TextBox();
            this.labelUpdateRoomPrice = new System.Windows.Forms.Label();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.txtBoxUpdateRoomName = new System.Windows.Forms.TextBox();
            this.labelUpdateRoomName = new System.Windows.Forms.Label();
            this.txtBoxUpdateRoomId = new System.Windows.Forms.TextBox();
            this.labelRoomId = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.txtBoxAddRoomPrice = new System.Windows.Forms.TextBox();
            this.labelRoomPrice = new System.Windows.Forms.Label();
            this.txtBoxAddRoomName = new System.Windows.Forms.TextBox();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTxtRoomInfo
            // 
            this.labelTxtRoomInfo.AutoSize = true;
            this.labelTxtRoomInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTxtRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTxtRoomInfo.Location = new System.Drawing.Point(72, 75);
            this.labelTxtRoomInfo.Name = "labelTxtRoomInfo";
            this.labelTxtRoomInfo.Size = new System.Drawing.Size(108, 15);
            this.labelTxtRoomInfo.TabIndex = 8;
            this.labelTxtRoomInfo.Text = "Room Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRoomDelete);
            this.groupBox2.Controls.Add(this.txtBoxUpdatePrice);
            this.groupBox2.Controls.Add(this.labelUpdateRoomPrice);
            this.groupBox2.Controls.Add(this.btnRoomUpdate);
            this.groupBox2.Controls.Add(this.txtBoxUpdateRoomName);
            this.groupBox2.Controls.Add(this.labelUpdateRoomName);
            this.groupBox2.Controls.Add(this.txtBoxUpdateRoomId);
            this.groupBox2.Controls.Add(this.labelRoomId);
            this.groupBox2.Location = new System.Drawing.Point(322, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 122);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Detail Info";
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Location = new System.Drawing.Point(238, 66);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(112, 23);
            this.btnRoomDelete.TabIndex = 7;
            this.btnRoomDelete.Text = "Delete Room";
            this.btnRoomDelete.UseVisualStyleBackColor = true;
            // 
            // txtBoxUpdatePrice
            // 
            this.txtBoxUpdatePrice.Location = new System.Drawing.Point(79, 82);
            this.txtBoxUpdatePrice.Name = "txtBoxUpdatePrice";
            this.txtBoxUpdatePrice.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUpdatePrice.TabIndex = 6;
            // 
            // labelUpdateRoomPrice
            // 
            this.labelUpdateRoomPrice.AutoSize = true;
            this.labelUpdateRoomPrice.Location = new System.Drawing.Point(6, 85);
            this.labelUpdateRoomPrice.Name = "labelUpdateRoomPrice";
            this.labelUpdateRoomPrice.Size = new System.Drawing.Size(62, 13);
            this.labelUpdateRoomPrice.TabIndex = 5;
            this.labelUpdateRoomPrice.Text = "Room Price";
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.Location = new System.Drawing.Point(238, 20);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(112, 23);
            this.btnRoomUpdate.TabIndex = 4;
            this.btnRoomUpdate.Text = "Update Room";
            this.btnRoomUpdate.UseVisualStyleBackColor = true;
            // 
            // txtBoxUpdateRoomName
            // 
            this.txtBoxUpdateRoomName.Location = new System.Drawing.Point(79, 50);
            this.txtBoxUpdateRoomName.Name = "txtBoxUpdateRoomName";
            this.txtBoxUpdateRoomName.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUpdateRoomName.TabIndex = 3;
            // 
            // labelUpdateRoomName
            // 
            this.labelUpdateRoomName.AutoSize = true;
            this.labelUpdateRoomName.Location = new System.Drawing.Point(7, 53);
            this.labelUpdateRoomName.Name = "labelUpdateRoomName";
            this.labelUpdateRoomName.Size = new System.Drawing.Size(66, 13);
            this.labelUpdateRoomName.TabIndex = 2;
            this.labelUpdateRoomName.Text = "Room Name";
            // 
            // txtBoxUpdateRoomId
            // 
            this.txtBoxUpdateRoomId.Location = new System.Drawing.Point(79, 17);
            this.txtBoxUpdateRoomId.Name = "txtBoxUpdateRoomId";
            this.txtBoxUpdateRoomId.ReadOnly = true;
            this.txtBoxUpdateRoomId.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUpdateRoomId.TabIndex = 1;
            // 
            // labelRoomId
            // 
            this.labelRoomId.AutoSize = true;
            this.labelRoomId.Location = new System.Drawing.Point(7, 20);
            this.labelRoomId.Name = "labelRoomId";
            this.labelRoomId.Size = new System.Drawing.Size(47, 13);
            this.labelRoomId.TabIndex = 0;
            this.labelRoomId.Text = "Room Id";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(133, 263);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.Size = new System.Drawing.Size(478, 102);
            this.dataGridViewRoom.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRoomAdd);
            this.groupBox1.Controls.Add(this.txtBoxAddRoomPrice);
            this.groupBox1.Controls.Add(this.labelRoomPrice);
            this.groupBox1.Controls.Add(this.txtBoxAddRoomName);
            this.groupBox1.Controls.Add(this.labelRoomName);
            this.groupBox1.Location = new System.Drawing.Point(72, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 122);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Room Info";
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Location = new System.Drawing.Point(131, 79);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(75, 23);
            this.btnRoomAdd.TabIndex = 4;
            this.btnRoomAdd.Text = "Add Room";
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            // 
            // txtBoxAddRoomPrice
            // 
            this.txtBoxAddRoomPrice.Location = new System.Drawing.Point(79, 53);
            this.txtBoxAddRoomPrice.Name = "txtBoxAddRoomPrice";
            this.txtBoxAddRoomPrice.Size = new System.Drawing.Size(127, 20);
            this.txtBoxAddRoomPrice.TabIndex = 3;
            // 
            // labelRoomPrice
            // 
            this.labelRoomPrice.AutoSize = true;
            this.labelRoomPrice.Location = new System.Drawing.Point(7, 56);
            this.labelRoomPrice.Name = "labelRoomPrice";
            this.labelRoomPrice.Size = new System.Drawing.Size(62, 13);
            this.labelRoomPrice.TabIndex = 2;
            this.labelRoomPrice.Text = "Room Price";
            // 
            // txtBoxAddRoomName
            // 
            this.txtBoxAddRoomName.Location = new System.Drawing.Point(79, 17);
            this.txtBoxAddRoomName.Name = "txtBoxAddRoomName";
            this.txtBoxAddRoomName.Size = new System.Drawing.Size(127, 20);
            this.txtBoxAddRoomName.TabIndex = 1;
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Location = new System.Drawing.Point(7, 20);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(66, 13);
            this.labelRoomName.TabIndex = 0;
            this.labelRoomName.Text = "Room Name";
            // 
            // RoomInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 439);
            this.Controls.Add(this.labelTxtRoomInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomInfoForm";
            this.Text = "Room Info";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTxtRoomInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.TextBox txtBoxUpdatePrice;
        private System.Windows.Forms.Label labelUpdateRoomPrice;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.TextBox txtBoxUpdateRoomName;
        private System.Windows.Forms.Label labelUpdateRoomName;
        private System.Windows.Forms.TextBox txtBoxUpdateRoomId;
        private System.Windows.Forms.Label labelRoomId;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.TextBox txtBoxAddRoomPrice;
        private System.Windows.Forms.Label labelRoomPrice;
        private System.Windows.Forms.TextBox txtBoxAddRoomName;
        private System.Windows.Forms.Label labelRoomName;
    }
}