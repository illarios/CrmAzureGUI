using System;
using System.Collections.Generic;
using System.Text;
using CrmAzureGUI.Data;
using CrmAzureGUI.Model;
using System.Linq;

namespace CrmAzureGUI.Services
{
    public class Servs : ServicesDef
    {
        public List<int> FindCustIds()
        {
            using CrmAzureDbContext appDb = new CrmAzureDbContext();
            List<int> ids = appDb
            .Customer
            .Select(p => p.Id)
            .ToList();
            return ids;
        }
        public List<Model.Customer> FindAll(int offset, int pageSize)
        {
            using CrmAzureDbContext appDb = new CrmAzureDbContext();
            List<Customer> customers = appDb
            .Customer
            .Select(p => p)
            .Skip(offset)
            .Take(pageSize)
            .ToList();
            return customers;
        }

        public List<Order> FindAll()
        {
            using CrmAzureDbContext appDb = new CrmAzureDbContext();
            List<Order> orders = appDb
            .Order
            .Select(p => p)
            .ToList();
            return orders;
        }

        public List<Order> FindOrders(int CustId)
        {
            using CrmAzureDbContext appDb = new CrmAzureDbContext();
            List<Order> orders = appDb
            .Order
            .Where(p => p.CustomerId == CustId)
            .ToList();
            return orders;
        }

        public List<Product> FindAllProducts()
        {
            using CrmAzureDbContext appDb = new CrmAzureDbContext();
            List<Product> products = appDb
            .Product
            .Select(p => p)
            .ToList();
            return products;
        }

        public List<OrderProduct> FindAllOrderProducts()
        {
            using CrmAzureDbContext appDb = new CrmAzureDbContext();
            List<OrderProduct> oproducts = appDb
            .OrderProduct
            .Select(p => p)
            .ToList();
            return oproducts;
        }
    }
}
