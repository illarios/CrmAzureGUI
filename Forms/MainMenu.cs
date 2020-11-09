using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrmAzureGUI.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BTN_cust_Click(object sender, EventArgs e)
        {
            Customers Check = new Customers();
            Check.Show();
            Hide();
        }

        private void BTN_orders_Click(object sender, EventArgs e)
        {
            Orders Check = new Orders();
            Check.Show();
            Hide();
        }

        private void BTN_prod_Click(object sender, EventArgs e)
        {
            Products Check = new Products();
            Check.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderProducts Check = new OrderProducts();
            Check.Show();
            Hide();
        }
    }
}
