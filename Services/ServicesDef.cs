using System;
using System.Collections.Generic;
using System.Text;
using CrmAzureGUI.Model;
using CrmAzureGUI.Data;

namespace CrmAzureGUI.Services
{
    public interface ServicesDef
    {
        List<Model.Customer> FindAll(int offset, int pageSize);
        List<Order> FindAll();
        List<Product> FindAllProducts();
        List<Order> FindOrders(int CustId);
        List<int> FindCustIds();
        List<OrderProduct> FindAllOrderProducts();
    }
}
