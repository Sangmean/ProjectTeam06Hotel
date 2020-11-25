namespace ProjectTeam06Hotel
{
    partial class HotelMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelMainForm));
            this.labelTxtMain = new System.Windows.Forms.Label();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonFrontDesk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTxtMain
            // 
            this.labelTxtMain.AutoSize = true;
            this.labelTxtMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.labelTxtMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelTxtMain.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxtMain.ForeColor = System.Drawing.Color.White;
            this.labelTxtMain.Location = new System.Drawing.Point(176, 73);
            this.labelTxtMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTxtMain.Name = "labelTxtMain";
            this.labelTxtMain.Size = new System.Drawing.Size(448, 348);
            this.labelTxtMain.TabIndex = 1;
            this.labelTxtMain.Text = "Vancouver \r\nBeachside\r\nHotel\r\n";
            this.labelTxtMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.Location = new System.Drawing.Point(78, 363);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(280, 158);
            this.buttonAdmin.TabIndex = 5;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonFrontDesk
            // 
            this.buttonFrontDesk.FlatAppearance.BorderSize = 0;
            this.buttonFrontDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFrontDesk.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFrontDesk.ForeColor = System.Drawing.Color.White;
            this.buttonFrontDesk.Image = ((System.Drawing.Image)(resources.GetObject("buttonFrontDesk.Image")));
            this.buttonFrontDesk.Location = new System.Drawing.Point(406, 363);
            this.buttonFrontDesk.Name = "buttonFrontDesk";
            this.buttonFrontDesk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonFrontDesk.Size = new System.Drawing.Size(280, 158);
            this.buttonFrontDesk.TabIndex = 5;
            this.buttonFrontDesk.Text = "Front Desk";
            this.buttonFrontDesk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFrontDesk.UseVisualStyleBackColor = true;
            // 
            // HotelMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(775, 582);
            this.Controls.Add(this.buttonFrontDesk);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.labelTxtMain);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HotelMainForm";
            this.Text = "Hotel Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTxtMain;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonFrontDesk;
    }
}

