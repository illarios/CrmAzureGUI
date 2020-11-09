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

namespace CrmAzureGUI.Forms
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicesDef cs = new Servs();
            List<Product> products = cs.FindAllProducts();
            dataGridView1.DataSource = products;
        }

        private void BTN_addProduct_Click(object sender, EventArgs e)
        {
            string name = TB_name.Text;
            string code = TB_code.Text;
            decimal price = decimal.Parse(TB_price.Text);

            using (var db = new CrmAzureDbContext())
            {
                var products = new Product()
                {
                    Name = name,
                    Code = code,
                    Price = price
                };
                db.Product.Add(products);
                db.SaveChanges();
            }
            TB_name.Text = String.Empty;
            TB_code.Text = String.Empty;
            TB_price.Text = String.Empty;
        }

        private void BTN_mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu Check = new MainMenu();
            Check.Show();
            Hide();
        }
    }
}
