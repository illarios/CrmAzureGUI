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

        //    using crmazuredbcontext appdb = new crmazuredbcontext();
        //    {
        //        var custs = appdb.customer
        //                 .include(blog => blog.posts
        //    .where(post => post.blogid == 1)
        //    .orderbydescending(post => post.title)
        //    .take(5))
        //    .theninclude(p => p.comments) // also include comments from posts
        //.tolist();
        //    }




            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

            Console.ReadLine();
        }
    }
}

