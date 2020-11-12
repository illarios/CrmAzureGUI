using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrmAzureGUI.Services;
using CrmAzureGUI.Model;
using CrmAzureGUI.Data;


namespace CrmAzureGUI.Forms
{
    public partial class OrderProducts : Form
    {
        public OrderProducts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServicesDef cs = new Servs();
            List<OrderProduct> oProducts = cs.FindAllOrderProducts();
            dataGridView1.DataSource = oProducts;
        }

        private void OrderProducts_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu Check = new MainMenu();
            Check.Show();
            Hide();
        }

        private void BTN_addOrdProd_Click(object sender, EventArgs e)
        {
            int prId = int.Parse(textBox2.Text);
            int ordId = int.Parse(textBox1.Text);

            using (var db = new CrmAzureDbContext())
            {
                var orderproduct = new Model.OrderProduct()
                {
                    ProductId = prId,
                    OrderId = ordId
   
                };
                db.OrderProduct.Add(orderproduct);
                db.SaveChanges();
            }
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;       
        }
    }
}
