using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmAzureGUI.Model;
using CrmAzureGUI.Services;
using CrmAzureGUI.Data;
using CrmAzureGUI.Forms;

namespace CrmAzureGUI
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_AddCust_Click(object sender, EventArgs e)
        {
            string name = TB_name.Text;
            string lname = TB_lname.Text;
            string ia = CB_IA.Checked.ToString();

            using (var db = new CrmAzureDbContext())
            {
                var customer = new Model.Customer()
                {
                    FirstName = name,
                    LastName = lname,
                    IsActive = ia == "False" ? false : true
                };
            db.Customer.Add(customer);
            db.SaveChanges();
            }
            TB_name.Text = String.Empty;
            TB_lname.Text = String.Empty;
            CB_IA.Checked = false;
        }

        private void DB_btn_Click_1(object sender, EventArgs e)
        {
            ServicesDef cs = new Servs();
            List<Model.Customer> customers = cs.FindAll(0, 50);
            dataGridView1.DataSource = customers;
        }

        private void BTN_remove_Click(object sender, EventArgs e)
        {

            using (var db = new CrmAzureDbContext())
            {
                int val;
               
                if (int.TryParse(TB_idRemove.Text, out val)) //Check if entry is a valid id format else ignore it
                {
                    //Check if entry exists else just ignore the input
                    var flag = (db.Customer.Where(p => p.Id == int.Parse(TB_idRemove.Text)).FirstOrDefault());
                    if (flag == null)
                    {
                        TB_idRemove.Text = String.Empty;
                        return;
                    }
                    else
                    {
                        db.Entry(flag).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                    }
                    var customer = new Model.Customer()
                    {
                        Id = int.Parse(TB_idRemove.Text)
                    };
                    db.Customer.Attach(customer);
                    db.Customer.Remove(customer);
                    db.SaveChanges();
                }
            }
            TB_idRemove.Text = String.Empty;
        }

        private void BTN_mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu Check = new MainMenu();
            Check.Show();
            Hide();
        }
    }
}
