using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmAzureGUI.Forms;
using CrmAzureGUI.Services;
using CrmAzureGUI.Data;
using CrmAzureGUI.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CrmAzureGUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            //using (var db = new CrmAzureDbContext())
            //{
            //    for (int i = 30; i < 40; i++)
            //    {
            //        Random rand = new Random();
            //        var customer = new Customer()
            //        {
            //            FirstName = "Customer" + i,
            //            LastName = "LastCustName" + i,
            //            IsActive = rand.Next(0, 2) == 0 ? false : true
            //        };
            //        db.Customer.Add(customer);
            //    }    
            //    db.SaveChanges();
            //}

            //using CrmAzureDbContext appdb = new CrmAzureDbContext();
            //{
            //    var custs = appdb.OrderProduct
            //      .Where(a => a.ProductId == 1)
            //      .Include(a => a.Product)
            //      .FirstOrDefault(a => a.ProductId == 1);

            //    var x = custs.Product.Price;
            //}

            //using CrmAzureDbContext appdb = new CrmAzureDbContext();
            //{

            //    var x = appdb.Order
            //    .Include(a => a.Customer)
            //    .Where(a => a.CustomerId == a.Customer.Id)
            //    .OrderBy(a => a.CustomerId)
            //    .ToList();

            //    Debug.WriteLine(x.Where(a => a.CustomerId == 13).Count());

            //}

            using CrmAzureDbContext appdb = new CrmAzureDbContext();
            {
                //get the total orders of each customer
                var customers = appdb.Customer.ToList();

                foreach (var i in customers)
                {
                    var x = appdb.OrderProduct
                    .Include(a => a.Order)
                        .ThenInclude(b => b.Customer)
                    .Where(b => b.Order.CustomerId == i.Id)
                    .Select(a => a.Product.Price)
                    .Sum();
                    Debug.WriteLine(x , i.Id.ToString());
                }
                    //foreach (var  a in x)
                //{
                //    var y = a.ProductId;
                //    var z = appdb.Product
                //      //  .Include( b => b.Price)
                //        .Where(b => b.Id == y)
                //        .Select(b => b.Price)
                //        .Sum();
                    
                    
                //    Debug.WriteLine(z);
                //}
               

                

            }



            //foreach(var oi in custs)
            //{

            //    Debug.WriteLine(oi.Id);
            //    Debug.WriteLine(oi.Orders.Where(a => a.CustomerId == oi.Id).Count());
            //}





            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

            Console.ReadLine();
        }
    }
}

