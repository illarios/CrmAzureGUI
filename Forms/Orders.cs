using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrmAzureGUI.Data;
using CrmAzureGUI.Model;
using CrmAzureGUI.Services;
using CrmAzureGUI.Forms;

namespace CrmAzureGUI
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void BTN_addOrder_Click(object sender, EventArgs e)
        {

        }

        private void CB_custIds_Click(object sender, EventArgs e)
        {
            ServicesDef cs = new Servs();
            List<int> ids = cs.FindCustIds();
            CB_custIds.DataSource = ids;

        }

        private void BTN_dbOrders_Click(object sender, EventArgs e)
        {
            ServicesDef cs = new Servs();
            List<Order> orders = cs.FindAll();
            dataGridView1.DataSource = orders;
        }

        private void BTN_addOrder_Click_1(object sender, EventArgs e)
        {
            string descr = TB_descr.Text;
            var date = Convert.ToDateTime(dateTimePicker1.Text);
            string addr = TB_addr.Text;
            int custId = int.Parse(CB_custIds.Text);

            using (var db = new CrmAzureDbContext())
            {
                var orders = new Order()
                {
                    Description = descr,
                    Created = date,
                    Address = addr,
                    CustomerId = custId
                };
                db.Order.Add(orders);
                db.SaveChanges();
            }
            TB_descr.Text = String.Empty;
            TB_addr.Text = String.Empty;
            CB_custIds.Text = String.Empty;
        }

        private void BTN_mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu Check = new MainMenu();
            Check.Show();
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
