using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Technical_Test.Models;

namespace Technical_Test.Services
{
    public class Service : IService
    {
        private IDataTables _dataTables;
        public string route;
        public Service(IDataTables dataTables) 
        {
            _dataTables = dataTables;
 
        }
        public string CatchRoute(OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {
                var filePath = openFileDialog.FileName;

                route = filePath;
            }

            return route;
        }
        public void ValidateComment(DataGridViewCellValidatingEventArgs e, DataGridView Grid_Order_Details)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == Grid_Order_Details.Columns["Price"].Index)
            {
                DataGridViewCell priceCell = Grid_Order_Details.Rows[e.RowIndex].Cells["Price"];
                DataGridViewCell commentCell = Grid_Order_Details.Rows[e.RowIndex].Cells["comment"];

                if (priceCell.Value != null && !string.IsNullOrWhiteSpace(priceCell.Value.ToString()))
                {
               
                    if (commentCell.Value == null || string.IsNullOrWhiteSpace(commentCell.Value.ToString()))
                    {
                        Grid_Order_Details.CancelEdit();
                        MessageBox.Show("If Price is Modified, Add Comment", "Validación de Datos",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                       
                    }
                }
            }

        }
        public void CreateRow(DataGridView grid, DataGridView gridDetail)
        {
            if (grid.SelectedRows.Count > 0)
            {
                ClientDto selectedOrder = (ClientDto)grid.SelectedRows[0].DataBoundItem;

                ProductDto newDetail = new()
                {
                    productName = "",
                    Price = null,
                    Quantity = null,
                    comment = ""
                };

                selectedOrder.OrderDetailsList.Add(newDetail);
                gridDetail.DataSource = null;
                gridDetail.DataSource = selectedOrder.OrderDetailsList;

            }
            else
            {
                MessageBox.Show("Select Order");
            }
        }
        public void InsertData(string orderNumber, List<ProductDto> orderDetails, DataGridView gridDetail)
        {
            string path = route;

            if (route == null)
            {
                MessageBox.Show("Route incorrect");
            }

            var xmlDoc = LoadFile();

            XElement orderElement = xmlDoc.Descendants("Orders")
                                          .FirstOrDefault(e => e.Element("NumberOrder").Value == orderNumber);
            if (orderElement != null)
            {
                //Clean Datagrid
                orderElement.Elements("OrderDetails").Remove();

                foreach (var detail in orderDetails)
                {
                    XElement detailElement = new XElement("OrderDetails",
                        new XElement("Product", detail.productName),
                        new XElement("Count", detail.Quantity),
                        new XElement("Price", detail.Price),
                        new XElement("Comment", detail.comment)
                    );

                    orderElement.Add(detailElement);
                }

                xmlDoc.Save(path);
            }
        }

        public void GetOrder(DataGridView grid, DataGridView gridDetail)
        {
            // DATATABLES
        
            var dtOrders = _dataTables.DataTableOrder();
            var dtOrderDetails = _dataTables.DataTableOrderDetail();

            if(route == null)
            {
                MessageBox.Show("Route incorrect");
            }

            var xmlDoc = LoadFile();

            List<ClientDto> ordersList = new List<ClientDto>();

            foreach (var orderElement in xmlDoc.Descendants("Orders"))
            {
                ClientDto order = new ClientDto

                {
                    OrderNumber = orderElement.Element("NumberOrder").Value,
                    Date = DateTime.Parse(orderElement.Element("CreateOrder").Value),
                    CustomerName = orderElement.Element("Client").Value,
                    OrderDetailsList = new List<ProductDto>()
                };

                int total = 0;
                double totalPrice = 0;

                foreach (var detailElement in orderElement.Descendants("OrderDetails"))
                {
                    // TOTAL ITEMS - TOTAL PRICE
                    int count = int.Parse(detailElement.Element("Count").Value);
                    total += count;
                    totalPrice += double.Parse(detailElement.Element("Price").Value) * count;

                    // FILL OrderDetails
                    ProductDto orderDetail = new ProductDto
                    {
                        productName = detailElement.Element("Product").Value,
                        Price = double.Parse(detailElement.Element("Price").Value),
                        Quantity = count,
                      
                        comment = detailElement.Element("Comment") != null ? detailElement.Element("Comment").Value : ""
                    };

                    order.OrderDetailsList.Add(orderDetail);

                    // FILL ROWS

                    DataRow detailRow = dtOrderDetails.NewRow();
                    detailRow["ProductName"] = orderDetail.productName;
                    detailRow["Price"] = orderDetail.Price;
                    detailRow["Quantity"] = orderDetail.Quantity;
                    detailRow["Comment"] = orderDetail.comment; 
                    dtOrderDetails.Rows.Add(detailRow);
                }

                order.ItemCount = total;
                order.TotalPrice = totalPrice;

                
                ordersList.Add(order);

                

                DataRow newRow = dtOrders.NewRow();
                newRow["OrderNumber"] = order.OrderNumber;
                newRow["Date"] = order.Date;
                newRow["CustomerName"] = order.CustomerName;
                newRow["ItemCount"] = order.ItemCount;
                newRow["TotalPrice"] = order.TotalPrice;
                dtOrders.Rows.Add(newRow);
            }

            
            grid.DataSource = ordersList;


        }

        public XDocument LoadFile()
        {
            XDocument xmlDoc = XDocument.Load(route);
            return xmlDoc;
        }

        public bool ValidateRows(DataGridView grid)
        {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
            
                            MessageBox.Show("Rows Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; 
                        }
                    }
                }

                return true;
            }
        public void ShowOrderDetails(string orderNumber, DataTable grid)
        {
            grid.Clear();
            
            var orderDetails = grid.Select($"OrderNumber = '{orderNumber}'");

            if (orderDetails.Length > 0)
            {
                foreach (var detailRow in orderDetails)
                {
                    DataRow newRow = grid.NewRow();
                    newRow["ProductName"] = detailRow["ProductName"];
                    newRow["Price"] = detailRow["Price"];
                    newRow["Quantity"] = detailRow["Quantity"];
                    newRow["Comment"] = detailRow["Comment"];
                    grid.Rows.Add(newRow);
                }
            }
            else
            {
                
                MessageBox.Show("Not Found");
            }
        }

        public void ValidateCellInsert(DataGridView grid,DataGridView gridDetail)
        {

            ProductDto products = new ProductDto();
            if (grid.SelectedRows.Count > 0)
            {
                bool exist = false;
                for (int i = 0; i < gridDetail.SelectedRows.Count;i++)
                {
                    if (gridDetail.Rows[i].Cells["ProductName"].Value == products.productName )
                    {
                        MessageBox.Show("Ya existe");
                        exist = true;
                        break;
                    }
                }
                if (exist == false)
                {
                    ClientDto selectedOrder = (ClientDto)grid.SelectedRows[0].DataBoundItem;
                  
                  InsertData(selectedOrder.OrderNumber, selectedOrder.OrderDetailsList, gridDetail);
                }
            }
            else
            {
                MessageBox.Show("Select a order");
            }

        }

        public void ValidateCell(DataGridViewCellEventArgs e,DataGridView grid, DataGridView gridDetail)
        {
         
                if (e.RowIndex >= 0)
                {
               
                  ClientDto selectedOrder = (ClientDto)grid.Rows[e.RowIndex].DataBoundItem;

                  gridDetail.DataSource = selectedOrder.OrderDetailsList;
                  
                }
            }


    }
}
