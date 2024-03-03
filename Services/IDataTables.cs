using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Test.Services
{
    public interface IDataTables
    {
        public DataTable DataTableOrder();
        public DataTable DataTableOrderDetail();
    }
}
