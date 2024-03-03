using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Test.Services
{
    public class DataTableService : IDataTables
    {
        public DataTable DataTableOrder()
        {
            DataTable dtOrders = new DataTable();

            dtOrders.Columns.Add("OrderNumber");
            dtOrders.Columns.Add("Date");
            dtOrders.Columns.Add("ItemCount", typeof(int));
            dtOrders.Columns.Add("TotalPrice", typeof(double));
            dtOrders.Columns.Add("CustomerName");

            return dtOrders;
        }

        public DataTable DataTableOrderDetail()
        {
            DataTable dtOrderDetails = new DataTable();

            dtOrderDetails.Columns.Add("ProductName");
            dtOrderDetails.Columns.Add("Price", typeof(double));
            dtOrderDetails.Columns.Add("Quantity", typeof(int));
            dtOrderDetails.Columns.Add("Comment");

            return dtOrderDetails;
        }
    }
}
