namespace ProjectTeam06Hotel
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.txtBoxAddRoomPrice = new System.Windows.Forms.TextBox();
            this.labelRoomPrice = new System.Windows.Forms.Label();
            this.txtBoxAddRoomName = new System.Windows.Forms.TextBox();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.txtBoxUpdatePrice = new System.Windows.Forms.TextBox();
            this.labelUpdateRoomPrice = new System.Windows.Forms.Label();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.txtBoxUpdateRoomName = new System.Windows.Forms.TextBox();
            this.labelUpdateRoomName = new System.Windows.Forms.Label();
            this.txtBoxUpdateRoomId = new System.Windows.Forms.TextBox();
            this.labelRoomId = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxAddCustomerPhone = new System.Windows.Forms.TextBox();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.btnAddCustomerInfo = new System.Windows.Forms.Button();
            this.txtBoxAddCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelCustomerAddress = new System.Windows.Forms.Label();
            this.txtBoxAddCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelTxtRoomInfo = new System.Windows.Forms.Label();
            this.labelTxtCustomerInfo = new System.Windows.Forms.Label();
            this.txtAddCustomerAge = new System.Windows.Forms.TextBox();
            this.labelCustomerAge = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBoxUpdateCustomerAge = new System.Windows.Forms.TextBox();
            this.labelUpdateCustomerAge = new System.Windows.Forms.Label();
            this.txtBoxUpdateCusotmerPhone = new System.Windows.Forms.TextBox();
            this.labelUpdateCustomerPhone = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtBoxUpdateCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelUpdateCustomerAddress = new System.Windows.Forms.Label();
            this.txtBoxUpdateCustomerName = new System.Windows.Forms.TextBox();
            this.labelUpdateCustomerName = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txtBoxUpdateCustomerId = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRoomAdd);
            this.groupBox1.Controls.Add(this.txtBoxAddRoomPrice);
            this.groupBox1.Controls.Add(this.labelRoomPrice);
            this.groupBox1.Controls.Add(this.txtBoxAddRoomName);
            this.groupBox1.Controls.Add(this.labelRoomName);
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 122);
            this.groupBox1.TabIndex = 0;
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
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(90, 161);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.Size = new System.Drawing.Size(478, 102);
            this.dataGridViewRoom.TabIndex = 1;
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
            this.groupBox2.Location = new System.Drawing.Point(274, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 122);
            this.groupBox2.TabIndex = 2;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAddCustomerAge);
            this.groupBox3.Controls.Add(this.labelCustomerAge);
            this.groupBox3.Controls.Add(this.txtBoxAddCustomerPhone);
            this.groupBox3.Controls.Add(this.labelCustomerPhone);
            this.groupBox3.Controls.Add(this.btnAddCustomerInfo);
            this.groupBox3.Controls.Add(this.txtBoxAddCustomerAddress);
            this.groupBox3.Controls.Add(this.labelCustomerAddress);
            this.groupBox3.Controls.Add(this.txtBoxAddCustomerName);
            this.groupBox3.Controls.Add(this.labelCustomerName);
            this.groupBox3.Location = new System.Drawing.Point(24, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 193);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Customer Info";
            // 
            // txtBoxAddCustomerPhone
            // 
            this.txtBoxAddCustomerPhone.Location = new System.Drawing.Point(66, 99);
            this.txtBoxAddCustomerPhone.Name = "txtBoxAddCustomerPhone";
            this.txtBoxAddCustomerPhone.Size = new System.Drawing.Size(127, 20);
            this.txtBoxAddCustomerPhone.TabIndex = 6;
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.AutoSize = true;
            this.labelCustomerPhone.Location = new System.Drawing.Point(6, 102);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(38, 13);
            this.labelCustomerPhone.TabIndex = 5;
            this.labelCustomerPhone.Text = "Phone";
            // 
            // btnAddCustomerInfo
            // 
            this.btnAddCustomerInfo.Location = new System.Drawing.Point(81, 164);
            this.btnAddCustomerInfo.Name = "btnAddCustomerInfo";
            this.btnAddCustomerInfo.Size = new System.Drawing.Size(112, 23);
            this.btnAddCustomerInfo.TabIndex = 4;
            this.btnAddCustomerInfo.Text = "Add Customer";
            this.btnAddCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // txtBoxAddCustomerAddress
            // 
            this.txtBoxAddCustomerAddress.Location = new System.Drawing.Point(66, 50);
            this.txtBoxAddCustomerAddress.Multiline = true;
            this.txtBoxAddCustomerAddress.Name = "txtBoxAddCustomerAddress";
            this.txtBoxAddCustomerAddress.Size = new System.Drawing.Size(127, 39);
            this.txtBoxAddCustomerAddress.TabIndex = 3;
            // 
            // labelCustomerAddress
            // 
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Location = new System.Drawing.Point(7, 53);
            this.labelCustomerAddress.Name = "labelCustomerAddress";
            this.labelCustomerAddress.Size = new System.Drawing.Size(45, 13);
            this.labelCustomerAddress.TabIndex = 2;
            this.labelCustomerAddress.Text = "Address";
            // 
            // txtBoxAddCustomerName
            // 
            this.txtBoxAddCustomerName.Location = new System.Drawing.Point(66, 17);
            this.txtBoxAddCustomerName.Name = "txtBoxAddCustomerName";
            this.txtBoxAddCustomerName.Size = new System.Drawing.Size(127, 20);
            this.txtBoxAddCustomerName.TabIndex = 1;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(7, 20);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(35, 13);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Name";
            // 
            // labelTxtRoomInfo
            // 
            this.labelTxtRoomInfo.AutoSize = true;
            this.labelTxtRoomInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTxtRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTxtRoomInfo.Location = new System.Drawing.Point(24, 5);
            this.labelTxtRoomInfo.Name = "labelTxtRoomInfo";
            this.labelTxtRoomInfo.Size = new System.Drawing.Size(108, 15);
            this.labelTxtRoomInfo.TabIndex = 4;
            this.labelTxtRoomInfo.Text = "Room Information";
            // 
            // labelTxtCustomerInfo
            // 
            this.labelTxtCustomerInfo.AutoSize = true;
            this.labelTxtCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTxtCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTxtCustomerInfo.Location = new System.Drawing.Point(24, 273);
            this.labelTxtCustomerInfo.Name = "labelTxtCustomerInfo";
            this.labelTxtCustomerInfo.Size = new System.Drawing.Size(128, 15);
            this.labelTxtCustomerInfo.TabIndex = 5;
            this.labelTxtCustomerInfo.Text = "Customer Information";
            // 
            // txtAddCustomerAge
            // 
            this.txtAddCustomerAge.Location = new System.Drawing.Point(66, 129);
            this.txtAddCustomerAge.Name = "txtAddCustomerAge";
            this.txtAddCustomerAge.Size = new System.Drawing.Size(127, 20);
            this.txtAddCustomerAge.TabIndex = 9;
            // 
            // labelCustomerAge
            // 
            this.labelCustomerAge.AutoSize = true;
            this.labelCustomerAge.Location = new System.Drawing.Point(6, 132);
            this.labelCustomerAge.Name = "labelCustomerAge";
            this.labelCustomerAge.Size = new System.Drawing.Size(26, 13);
            this.labelCustomerAge.TabIndex = 8;
            this.labelCustomerAge.Text = "Age";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxUpdateCustomerId);
            this.groupBox4.Controls.Add(this.labelCustomerId);
            this.groupBox4.Controls.Add(this.btnDeleteCustomer);
            this.groupBox4.Controls.Add(this.txtBoxUpdateCustomerAge);
            this.groupBox4.Controls.Add(this.labelUpdateCustomerAge);
            this.groupBox4.Controls.Add(this.txtBoxUpdateCusotmerPhone);
            this.groupBox4.Controls.Add(this.labelUpdateCustomerPhone);
            this.groupBox4.Controls.Add(this.btnUpdateCustomer);
            this.groupBox4.Controls.Add(this.txtBoxUpdateCustomerAddress);
            this.groupBox4.Controls.Add(this.labelUpdateCustomerAddress);
            this.groupBox4.Controls.Add(this.txtBoxUpdateCustomerName);
            this.groupBox4.Controls.Add(this.labelUpdateCustomerName);
            this.groupBox4.Location = new System.Drawing.Point(284, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 205);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Customer Info";
            // 
            // txtBoxUpdateCustomerAge
            // 
            this.txtBoxUpdateCustomerAge.Location = new System.Drawing.Point(65, 162);
            this.txtBoxUpdateCustomerAge.Name = "txtBoxUpdateCustomerAge";
            this.txtBoxUpdateCustomerAge.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUpdateCustomerAge.TabIndex = 9;
            // 
            // labelUpdateCustomerAge
            // 
            this.labelUpdateCustomerAge.AutoSize = true;
            this.labelUpdateCustomerAge.Location = new System.Drawing.Point(6, 165);
            this.labelUpdateCustomerAge.Name = "labelUpdateCustomerAge";
            this.labelUpdateCustomerAge.Size = new System.Drawing.Size(26, 13);
            this.labelUpdateCustomerAge.TabIndex = 8;
            this.labelUpdateCustomerAge.Text = "Age";
            // 
            // txtBoxUpdateCusotmerPhone
            // 
            this.txtBoxUpdateCusotmerPhone.Location = new System.Drawing.Point(65, 132);
            this.txtBoxUpdateCusotmerPhone.Name = "txtBoxUpdateCusotmerPhone";
            this.txtBoxUpdateCusotmerPhone.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUpdateCusotmerPhone.TabIndex = 6;
            // 
            // labelUpdateCustomerPhone
            // 
            this.labelUpdateCustomerPhone.AutoSize = true;
            this.labelUpdateCustomerPhone.Location = new System.Drawing.Point(5, 135);
            this.labelUpdateCustomerPhone.Name = "labelUpdateCustomerPhone";
            this.labelUpdateCustomerPhone.Size = new System.Drawing.Size(38, 13);
            this.labelUpdateCustomerPhone.TabIndex = 5;
            this.labelUpdateCustomerPhone.Text = "Phone";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(211, 65);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateCustomer.TabIndex = 4;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // txtBoxUpdateCustomerAddress
            // 
            this.txtBoxUpdateCustomerAddress.Location = new System.Drawing.Point(65, 83);
            this.txtBoxUpdateCustomerAddress.Multiline = true;
            this.txtBoxUpdateCustomerAddress.Name = "txtBoxUpdateCustomerAddress";
            this.txtBoxUpdateCustomerAddress.Size = new System.Drawing.Size(127, 39);
            this.txtBoxUpdateCustomerAddress.TabIndex = 3;
            // 
            // labelUpdateCustomerAddress
            // 
            this.labelUpdateCustomerAddress.AutoSize = true;
            this.labelUpdateCustomerAddress.Location = new System.Drawing.Point(6, 86);
            this.labelUpdateCustomerAddress.Name = "labelUpdateCustomerAddress";
            this.labelUpdateCustomerAddress.Size = new System.Drawing.Size(45, 13);
            this.labelUpdateCustomerAddress.TabIndex = 2;
            this.labelUpdateCustomerAddress.Text = "Address";
            // 
            // txtBoxUpdateCustomerName
            // 
            this.txtBoxUpdateCustomerName.Location = new System.Drawing.Point(65, 50);
            this.txtBoxUpdateCustomerName.Name = "txtBoxUpdateCustomerName";
            this.txtBoxUpdateCustomerName.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUpdateCustomerName.TabIndex = 1;
            // 
            // labelUpdateCustomerName
            // 
            this.labelUpdateCustomerName.AutoSize = true;
            this.labelUpdateCustomerName.Location = new System.Drawing.Point(6, 53);
            this.labelUpdateCustomerName.Name = "labelUpdateCustomerName";
            this.labelUpdateCustomerName.Size = new System.Drawing.Size(35, 13);
            this.labelUpdateCustomerName.TabIndex = 0;
            this.labelUpdateCustomerName.Text = "Name";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(211, 125);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteCustomer.TabIndex = 10;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // txtBoxUpdateCustomerId
            // 
            this.txtBoxUpdateCustomerId.Location = new System.Drawing.Point(65, 24);
            this.txtBoxUpdateCustomerId.Name = "txtBoxUpdateCustomerId";
            this.txtBoxUpdateCustomerId.ReadOnly = true;
            this.txtBoxUpdateCustomerId.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUpdateCustomerId.TabIndex = 12;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(6, 27);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(16, 13);
            this.labelCustomerId.TabIndex = 11;
            this.labelCustomerId.Text = "Id";
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(90, 530);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(478, 123);
            this.dataGridViewCustomer.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 696);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelTxtCustomerInfo);
            this.Controls.Add(this.labelTxtRoomInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hotel Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxAddRoomName;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.TextBox txtBoxAddRoomPrice;
        private System.Windows.Forms.Label labelRoomPrice;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxUpdatePrice;
        private System.Windows.Forms.Label labelUpdateRoomPrice;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.TextBox txtBoxUpdateRoomName;
        private System.Windows.Forms.Label labelUpdateRoomName;
        private System.Windows.Forms.TextBox txtBoxUpdateRoomId;
        private System.Windows.Forms.Label labelRoomId;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxAddCustomerPhone;
        private System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.Button btnAddCustomerInfo;
        private System.Windows.Forms.TextBox txtBoxAddCustomerAddress;
        private System.Windows.Forms.Label labelCustomerAddress;
        private System.Windows.Forms.TextBox txtBoxAddCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelTxtRoomInfo;
        private System.Windows.Forms.Label labelTxtCustomerInfo;
        private System.Windows.Forms.TextBox txtAddCustomerAge;
        private System.Windows.Forms.Label labelCustomerAge;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxUpdateCustomerId;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtBoxUpdateCustomerAge;
        private System.Windows.Forms.Label labelUpdateCustomerAge;
        private System.Windows.Forms.TextBox txtBoxUpdateCusotmerPhone;
        private System.Windows.Forms.Label labelUpdateCustomerPhone;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox txtBoxUpdateCustomerAddress;
        private System.Windows.Forms.Label labelUpdateCustomerAddress;
        private System.Windows.Forms.TextBox txtBoxUpdateCustomerName;
        private System.Windows.Forms.Label labelUpdateCustomerName;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
    }
}

