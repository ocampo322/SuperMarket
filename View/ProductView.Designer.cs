namespace Supermarket_mvp.View
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductStock = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            label3 = new Label();
            bv = new Label();
            mano = new Label();
            epa = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.agregar_producto;
            pictureBox1.Location = new Point(23, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(234, 48);
            label1.Name = "label1";
            label1.Size = new Size(161, 54);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1128, 511);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 34);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(1120, 473);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(798, 372);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(269, 85);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(798, 281);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(269, 85);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(798, 190);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(269, 85);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(798, 99);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(269, 85);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(35, 109);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowHeadersWidth = 62;
            DgProduct.Size = new Size(726, 347);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(693, 21);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(68, 64);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(35, 54);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(652, 31);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 21);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Controls.Add(bv);
            tabPageProductDetail.Controls.Add(mano);
            tabPageProductDetail.Controls.Add(epa);
            tabPageProductDetail.Location = new Point(4, 34);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(1120, 473);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(911, 352);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(136, 98);
            BtnCancel.TabIndex = 10;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(742, 352);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(136, 98);
            BtnSave.TabIndex = 9;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(35, 386);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "Producto Stock";
            TxtProductStock.Size = new Size(317, 31);
            TxtProductStock.TabIndex = 8;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(35, 275);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "Producto Price";
            TxtProductPrice.Size = new Size(317, 31);
            TxtProductPrice.TabIndex = 7;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(36, 173);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Producto Id";
            TxtProductName.Size = new Size(317, 31);
            TxtProductName.TabIndex = 6;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(36, 81);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.PlaceholderText = "0";
            TxtProductId.Size = new Size(317, 31);
            TxtProductId.TabIndex = 5;
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 358);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 4;
            label3.Text = "Product Stock";
            // 
            // bv
            // 
            bv.AutoSize = true;
            bv.Location = new Point(36, 247);
            bv.Name = "bv";
            bv.Size = new Size(116, 25);
            bv.TabIndex = 3;
            bv.Text = "Product Price";
            // 
            // mano
            // 
            mano.AutoSize = true;
            mano.Location = new Point(35, 145);
            mano.Name = "mano";
            mano.Size = new Size(126, 25);
            mano.TabIndex = 2;
            mano.Text = "Product Name";
            // 
            // epa
            // 
            epa.AutoSize = true;
            epa.Location = new Point(36, 53);
            epa.Name = "epa";
            epa.Size = new Size(95, 25);
            epa.TabIndex = 1;
            epa.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 661);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageProductDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private Label mano;
        private Label epa;
        private TextBox TxtProductId;
        private Label label3;
        private Label bv;
        private TextBox TxtProductPrice;
        private TextBox TxtProductName;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductStock;
    }
}