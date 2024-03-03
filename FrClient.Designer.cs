using System;

namespace Technical_Test
{
    partial class FrClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Search_Order = new Button();
            Btn_Previous_Order_Details = new Button();
            Btn_Next_Order_Details = new Button();
            Btn_Search_Order_Details = new Button();
            Btn_Previous_Order = new Button();
            Btn_Next_Order = new Button();
            Text_Box_Order_Details = new TextBox();
            TexBox_Order = new TextBox();
            Grid_Order_Details = new DataGridView();
            productNameColumn = new DataGridViewTextBoxColumn();
            Grid_Order = new DataGridView();
            Btn_Load_File = new Button();
            Btn_Save = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            BtnAgregar = new Button();
            Orders = new Label();
            OrderDetail = new Label();
            Btn_Update_Grid = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid_Order_Details).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Order).BeginInit();
            SuspendLayout();
            // 
            // Btn_Search_Order
            // 
            Btn_Search_Order.Location = new Point(405, 302);
            Btn_Search_Order.Name = "Btn_Search_Order";
            Btn_Search_Order.Size = new Size(78, 29);
            Btn_Search_Order.TabIndex = 36;
            Btn_Search_Order.Text = "Search";
            Btn_Search_Order.UseVisualStyleBackColor = true;
            Btn_Search_Order.Click += Btn_Search_Order_Click;
            // 
            // Btn_Previous_Order_Details
            // 
            Btn_Previous_Order_Details.Location = new Point(593, 549);
            Btn_Previous_Order_Details.Name = "Btn_Previous_Order_Details";
            Btn_Previous_Order_Details.Size = new Size(108, 29);
            Btn_Previous_Order_Details.TabIndex = 33;
            Btn_Previous_Order_Details.Text = "Previous";
            Btn_Previous_Order_Details.UseVisualStyleBackColor = true;
            Btn_Previous_Order_Details.Click += Btn_Previous_Order_Details_Click;
            // 
            // Btn_Next_Order_Details
            // 
            Btn_Next_Order_Details.Location = new Point(503, 548);
            Btn_Next_Order_Details.Name = "Btn_Next_Order_Details";
            Btn_Next_Order_Details.Size = new Size(75, 29);
            Btn_Next_Order_Details.TabIndex = 32;
            Btn_Next_Order_Details.Text = "Next";
            Btn_Next_Order_Details.UseVisualStyleBackColor = true;
            Btn_Next_Order_Details.Click += Btn_Next_Order_Details_Click;
            // 
            // Btn_Search_Order_Details
            // 
            Btn_Search_Order_Details.Location = new Point(405, 547);
            Btn_Search_Order_Details.Name = "Btn_Search_Order_Details";
            Btn_Search_Order_Details.Size = new Size(78, 29);
            Btn_Search_Order_Details.TabIndex = 31;
            Btn_Search_Order_Details.Text = "Search";
            Btn_Search_Order_Details.UseVisualStyleBackColor = true;
            Btn_Search_Order_Details.Click += Btn_Search_Order_Details_Click;
            // 
            // Btn_Previous_Order
            // 
            Btn_Previous_Order.Location = new Point(593, 302);
            Btn_Previous_Order.Name = "Btn_Previous_Order";
            Btn_Previous_Order.Size = new Size(108, 29);
            Btn_Previous_Order.TabIndex = 30;
            Btn_Previous_Order.Text = "Previous";
            Btn_Previous_Order.UseVisualStyleBackColor = true;
            Btn_Previous_Order.Click += Btn_Previous_Order_Click;
            // 
            // Btn_Next_Order
            // 
            Btn_Next_Order.Location = new Point(500, 302);
            Btn_Next_Order.Name = "Btn_Next_Order";
            Btn_Next_Order.Size = new Size(78, 29);
            Btn_Next_Order.TabIndex = 29;
            Btn_Next_Order.Text = "Next";
            Btn_Next_Order.UseVisualStyleBackColor = true;
            Btn_Next_Order.Click += Btn_Next_Order_Click;
            // 
            // Text_Box_Order_Details
            // 
            Text_Box_Order_Details.Location = new Point(206, 549);
            Text_Box_Order_Details.Name = "Text_Box_Order_Details";
            Text_Box_Order_Details.Size = new Size(167, 27);
            Text_Box_Order_Details.TabIndex = 28;
            // 
            // TexBox_Order
            // 
            TexBox_Order.Location = new Point(202, 302);
            TexBox_Order.Name = "TexBox_Order";
            TexBox_Order.Size = new Size(171, 27);
            TexBox_Order.TabIndex = 27;
            // 
            // Grid_Order_Details
            // 
            Grid_Order_Details.AllowUserToDeleteRows = false;
            Grid_Order_Details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Order_Details.Columns.AddRange(new DataGridViewColumn[] { productNameColumn });
            Grid_Order_Details.Location = new Point(23, 361);
            Grid_Order_Details.Name = "Grid_Order_Details";
            Grid_Order_Details.RowHeadersWidth = 51;
            Grid_Order_Details.Size = new Size(555, 165);
            Grid_Order_Details.TabIndex = 26;
            Grid_Order_Details.CellValidating += Grid_Order_Details_CellValidating;
            // 
            // productNameColumn
            // 
            productNameColumn.DataPropertyName = "productName";
            productNameColumn.HeaderText = "Product Name";
            productNameColumn.MinimumWidth = 6;
            productNameColumn.Name = "productNameColumn";
            productNameColumn.ReadOnly = true;
            productNameColumn.Width = 125;
            // 
            // Grid_Order
            // 
            Grid_Order.AllowUserToDeleteRows = false;
            Grid_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Order.Location = new Point(23, 85);
            Grid_Order.Name = "Grid_Order";
            Grid_Order.RowHeadersWidth = 51;
            Grid_Order.Size = new Size(678, 195);
            Grid_Order.TabIndex = 25;
            Grid_Order.CellClick += Grid_Order_CellClick;
            // 
            // Btn_Load_File
            // 
            Btn_Load_File.Location = new Point(23, 12);
            Btn_Load_File.Name = "Btn_Load_File";
            Btn_Load_File.Size = new Size(81, 28);
            Btn_Load_File.TabIndex = 37;
            Btn_Load_File.Text = "Load File";
            Btn_Load_File.UseVisualStyleBackColor = true;
            Btn_Load_File.Click += Btn_Load_File_Click;
            // 
            // Btn_Save
            // 
            Btn_Save.Location = new Point(595, 478);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(106, 33);
            Btn_Save.TabIndex = 38;
            Btn_Save.Text = "Save";
            Btn_Save.UseVisualStyleBackColor = true;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Archivos Xml(*.xml)|*xml";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 301);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 39;
            label1.Text = "Search by Order Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 552);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 40;
            label2.Text = "Search by Product Name";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(595, 361);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(106, 32);
            BtnAgregar.TabIndex = 41;
            BtnAgregar.Text = "Add Product";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // Orders
            // 
            Orders.AutoSize = true;
            Orders.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            Orders.Location = new Point(23, 50);
            Orders.Name = "Orders";
            Orders.Size = new Size(59, 20);
            Orders.TabIndex = 42;
            Orders.Text = "Orders";
            // 
            // OrderDetail
            // 
            OrderDetail.AutoSize = true;
            OrderDetail.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderDetail.Location = new Point(23, 328);
            OrderDetail.Name = "OrderDetail";
            OrderDetail.Size = new Size(106, 20);
            OrderDetail.TabIndex = 43;
            OrderDetail.Text = "Order Details";
            // 
            // Btn_Update_Grid
            // 
            Btn_Update_Grid.Location = new Point(593, 423);
            Btn_Update_Grid.Name = "Btn_Update_Grid";
            Btn_Update_Grid.Size = new Size(108, 31);
            Btn_Update_Grid.TabIndex = 44;
            Btn_Update_Grid.Text = "Update Grid";
            Btn_Update_Grid.UseVisualStyleBackColor = true;
            Btn_Update_Grid.Click += Btn_Update_Grid_Click;
            // 
            // FrClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 594);
            Controls.Add(Btn_Update_Grid);
            Controls.Add(OrderDetail);
            Controls.Add(Orders);
            Controls.Add(BtnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Save);
            Controls.Add(Btn_Load_File);
            Controls.Add(Btn_Search_Order);
            Controls.Add(Btn_Previous_Order_Details);
            Controls.Add(Btn_Next_Order_Details);
            Controls.Add(Btn_Search_Order_Details);
            Controls.Add(Btn_Previous_Order);
            Controls.Add(Btn_Next_Order);
            Controls.Add(Text_Box_Order_Details);
            Controls.Add(TexBox_Order);
            Controls.Add(Grid_Order_Details);
            Controls.Add(Grid_Order);
            Name = "FrClient";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grid_Order_Details).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button Btn_Search_Order;
        internal Button Btn_Previous_Order_Details;
        internal Button Btn_Next_Order_Details;
        internal Button Btn_Search_Order_Details;
        internal Button Btn_Previous_Order;
        internal Button Btn_Next_Order;
        internal TextBox Text_Box_Order_Details;
        internal TextBox TexBox_Order;
        internal DataGridView Grid_Order_Details;
        internal DataGridView Grid_Order;
        private Button Btn_Load_File;
        private Button Btn_Save;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Button BtnAgregar;
        private Label Orders;
        private Label OrderDetail;
        private DataGridViewTextBoxColumn productNameColumn;
        private Button Btn_Update_Grid;
    }
}
