using System;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Technical_Test.Models;
using Technical_Test.Services;
namespace Technical_Test
{
    public partial class FrClient : Form
    {

        public IService _services;
        private IPagination _pagination;
        private bool comentarioRequerido = false;
        public FrClient(IService products,
                        IPagination pagination)
        {
            InitializeComponent();
            _services = products;
            _pagination = pagination;
        }
        private void Btn_Load_File_Click(object sender, EventArgs e)
        {
            _services.CatchRoute(openFileDialog1);
            _services.GetOrder(Grid_Order, Grid_Order_Details);

        }
        private void Btn_Search_Order_Click(object sender, EventArgs e)

        {
            _pagination.ShowOrder(Grid_Order, TexBox_Order);
        }


        private void Btn_Save_Click(object sender, EventArgs e)
        {

            _services.ValidateCellInsert(Grid_Order, Grid_Order_Details);

        }

        private void Grid_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            _services.ValidateCell(e, Grid_Order, Grid_Order_Details);
        }

        private void Btn_Search_Order_Details_Click(object sender, EventArgs e)
        {
            _pagination.ShowOrder(Grid_Order_Details, Text_Box_Order_Details);
        }

        private void Btn_Next_Order_Click(object sender, EventArgs e)
        {
            _pagination.Next(Grid_Order);
        }

        private void Btn_Next_Order_Details_Click(object sender, EventArgs e)
        {
            _pagination.Next(Grid_Order_Details);
        }

        private void Btn_Previous_Order_Click(object sender, EventArgs e)
        {
            _pagination.Previous(Grid_Order);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _services.CreateRow(Grid_Order, Grid_Order_Details);
        }

        private void Btn_Previous_Order_Details_Click(object sender, EventArgs e)
        {
            _pagination.Previous(Grid_Order_Details);
        }

        private void Grid_Order_Details_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            _services.ValidateComment(e, Grid_Order_Details);
        }

        private void Btn_Update_Grid_Click(object sender, EventArgs e)
        {

            _services.GetOrder(Grid_Order, Grid_Order_Details);

        }
    }
}



