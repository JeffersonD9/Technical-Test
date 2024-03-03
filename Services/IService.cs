using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Technical_Test.Models;

namespace Technical_Test.Services
{
    public interface IService
    {
        public XDocument LoadFile();
        //public void RefreshXML(DataGridView grid);
        public void InsertData(string orderNumber, List<ProductDto> orderDetails, DataGridView gridDetail);
        public bool ValidateRows(DataGridView grid);
        public void ValidateCellInsert(DataGridView grid, DataGridView gridDetail);
        public void ValidateCell(DataGridViewCellEventArgs e, DataGridView grid, DataGridView gridDetail);
        public string CatchRoute(OpenFileDialog openFileDialog);
        public void CreateRow(DataGridView grid, DataGridView gridDetail);
        public void ShowOrderDetails(string orderNumber, DataTable grid);
        public void GetOrder(DataGridView grid, DataGridView gridDetail);
       // public void Save();
        public void ValidateComment(DataGridViewCellValidatingEventArgs e, DataGridView Grid_Order_Details);
    }
}
