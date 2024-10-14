namespace Supermarket_mvp.View
{
    partial class CustomerView
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
            tabPageCustomerList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomer = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomerDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCustomerEmail = new TextBox();
            label9 = new Label();
            TxtCustomerPhoneNumber = new TextBox();
            label8 = new Label();
            TxtCustomerBirthday = new TextBox();
            label7 = new Label();
            TxtCustomerAddress = new TextBox();
            label6 = new Label();
            TxtCustomerLastName = new TextBox();
            label5 = new Label();
            TxtCustomerFirstName = new TextBox();
            label4 = new Label();
            TxtCustomerDocumentNumber = new TextBox();
            label3 = new Label();
            TxtCustomerId = new TextBox();
            veneco = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).BeginInit();
            tabPageCustomerDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.customer_review;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(214, 43);
            label1.Name = "label1";
            label1.Size = new Size(148, 64);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1032, 516);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(DgCustomer);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(TxtSearch);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 34);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(1024, 478);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(761, 397);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(223, 75);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(761, 306);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(223, 75);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(761, 206);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(223, 75);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(761, 110);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(223, 75);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomer
            // 
            DgCustomer.AllowUserToAddRows = false;
            DgCustomer.AllowUserToDeleteRows = false;
            DgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomer.Location = new Point(19, 110);
            DgCustomer.Name = "DgCustomer";
            DgCustomer.ReadOnly = true;
            DgCustomer.RowHeadersWidth = 62;
            DgCustomer.Size = new Size(721, 362);
            DgCustomer.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(657, 39);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(83, 62);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(19, 55);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(632, 31);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 27);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Customer";
            // 
            // tabPageCustomerDetail
            // 
            tabPageCustomerDetail.Controls.Add(BtnCancel);
            tabPageCustomerDetail.Controls.Add(BtnSave);
            tabPageCustomerDetail.Controls.Add(TxtCustomerEmail);
            tabPageCustomerDetail.Controls.Add(label9);
            tabPageCustomerDetail.Controls.Add(TxtCustomerPhoneNumber);
            tabPageCustomerDetail.Controls.Add(label8);
            tabPageCustomerDetail.Controls.Add(TxtCustomerBirthday);
            tabPageCustomerDetail.Controls.Add(label7);
            tabPageCustomerDetail.Controls.Add(TxtCustomerAddress);
            tabPageCustomerDetail.Controls.Add(label6);
            tabPageCustomerDetail.Controls.Add(TxtCustomerLastName);
            tabPageCustomerDetail.Controls.Add(label5);
            tabPageCustomerDetail.Controls.Add(TxtCustomerFirstName);
            tabPageCustomerDetail.Controls.Add(label4);
            tabPageCustomerDetail.Controls.Add(TxtCustomerDocumentNumber);
            tabPageCustomerDetail.Controls.Add(label3);
            tabPageCustomerDetail.Controls.Add(TxtCustomerId);
            tabPageCustomerDetail.Controls.Add(veneco);
            tabPageCustomerDetail.Location = new Point(4, 34);
            tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            tabPageCustomerDetail.Padding = new Padding(3);
            tabPageCustomerDetail.Size = new Size(1024, 478);
            tabPageCustomerDetail.TabIndex = 1;
            tabPageCustomerDetail.Text = "Customer Detail";
            tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(865, 359);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(127, 87);
            BtnCancel.TabIndex = 17;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(718, 359);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(127, 87);
            BtnSave.TabIndex = 16;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(403, 369);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.PlaceholderText = "Customer Email";
            TxtCustomerEmail.Size = new Size(214, 31);
            TxtCustomerEmail.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(403, 341);
            label9.Name = "label9";
            label9.Size = new Size(136, 25);
            label9.TabIndex = 14;
            label9.Text = "Customer Email";
            // 
            // TxtCustomerPhoneNumber
            // 
            TxtCustomerPhoneNumber.Location = new Point(403, 256);
            TxtCustomerPhoneNumber.Name = "TxtCustomerPhoneNumber";
            TxtCustomerPhoneNumber.PlaceholderText = "Customer Phone Number";
            TxtCustomerPhoneNumber.Size = new Size(214, 31);
            TxtCustomerPhoneNumber.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 228);
            label8.Name = "label8";
            label8.Size = new Size(214, 25);
            label8.TabIndex = 12;
            label8.Text = "Customer Phone Number";
            // 
            // TxtCustomerBirthday
            // 
            TxtCustomerBirthday.Location = new Point(403, 155);
            TxtCustomerBirthday.Name = "TxtCustomerBirthday";
            TxtCustomerBirthday.PlaceholderText = "Customer Birthday";
            TxtCustomerBirthday.Size = new Size(214, 31);
            TxtCustomerBirthday.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 127);
            label7.Name = "label7";
            label7.Size = new Size(159, 25);
            label7.TabIndex = 10;
            label7.Text = "Customer Birthday";
            // 
            // TxtCustomerAddress
            // 
            TxtCustomerAddress.Location = new Point(412, 57);
            TxtCustomerAddress.Name = "TxtCustomerAddress";
            TxtCustomerAddress.PlaceholderText = "Customer Address";
            TxtCustomerAddress.Size = new Size(205, 31);
            TxtCustomerAddress.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 29);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 8;
            label6.Text = "Customer Address";
            // 
            // TxtCustomerLastName
            // 
            TxtCustomerLastName.Location = new Point(54, 369);
            TxtCustomerLastName.Name = "TxtCustomerLastName";
            TxtCustomerLastName.PlaceholderText = "Customer Last Name";
            TxtCustomerLastName.Size = new Size(263, 31);
            TxtCustomerLastName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 341);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 6;
            label5.Text = "Customer Last Name";
            // 
            // TxtCustomerFirstName
            // 
            TxtCustomerFirstName.Location = new Point(54, 265);
            TxtCustomerFirstName.Name = "TxtCustomerFirstName";
            TxtCustomerFirstName.PlaceholderText = "Customer First Name";
            TxtCustomerFirstName.Size = new Size(263, 31);
            TxtCustomerFirstName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 228);
            label4.Name = "label4";
            label4.Size = new Size(179, 25);
            label4.TabIndex = 4;
            label4.Text = "Customer First Name";
            // 
            // TxtCustomerDocumentNumber
            // 
            TxtCustomerDocumentNumber.Location = new Point(56, 155);
            TxtCustomerDocumentNumber.Name = "TxtCustomerDocumentNumber";
            TxtCustomerDocumentNumber.PlaceholderText = "Customer Document Number";
            TxtCustomerDocumentNumber.Size = new Size(261, 31);
            TxtCustomerDocumentNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 127);
            label3.Name = "label3";
            label3.Size = new Size(247, 25);
            label3.TabIndex = 2;
            label3.Text = "Customer Document Number";
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(56, 57);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.PlaceholderText = "Customer Id";
            TxtCustomerId.ReadOnly = true;
            TxtCustomerId.Size = new Size(150, 31);
            TxtCustomerId.TabIndex = 1;
            TxtCustomerId.Text = "0";
            TxtCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // veneco
            // 
            veneco.AutoSize = true;
            veneco.Location = new Point(56, 29);
            veneco.Name = "veneco";
            veneco.Size = new Size(110, 25);
            veneco.TabIndex = 0;
            veneco.Text = "Customer Id";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 666);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "Customer Management";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).EndInit();
            tabPageCustomerDetail.ResumeLayout(false);
            tabPageCustomerDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private TabPage tabPageCustomerDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button button2;
        private Button BtnNew;
        private DataGridView DgCustomer;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Label veneco;
        private TextBox TxtCustomerId;
        private Label label3;
        private TextBox TxtCustomerDocumentNumber;
        private Label label4;
        private TextBox TxtCustomerFirstName;
        private Label label5;
        private TextBox TxtCustomerLastName;
        private Label label6;
        private TextBox TxtCustomerAddress;
        private Label label7;
        private TextBox TxtCustomerBirthday;
        private TextBox TxtCustomerPhoneNumber;
        private Label label8;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCustomerEmail;
        private Label label9;
    }
}