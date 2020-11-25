using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam06Hotel
{
    public partial class HotelMainForm : Form
    {
        public HotelMainForm()
        {
            InitializeComponent();

            buttonAdmin.Click += ButtonAdmin_Click;
            buttonFrontDesk.Click += ButtonFrontDesk_Click;
        }

        private void ButtonFrontDesk_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            RoomInfoForm roomInfo = new RoomInfoForm();
            roomInfo.ShowDialog();
        }

    }
}
