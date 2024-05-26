using System;

namespace ProjectGMS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDetailInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.storeToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 68);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(880, 38);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInformationToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // customerInformationToolStripMenuItem
            // 
            this.customerInformationToolStripMenuItem.Name = "customerInformationToolStripMenuItem";
            this.customerInformationToolStripMenuItem.Size = new System.Drawing.Size(325, 30);
            this.customerInformationToolStripMenuItem.Text = "Customer Information";
            this.customerInformationToolStripMenuItem.Click += new System.EventHandler(this.customerInformationToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesInformationToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(125, 30);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // employeesInformationToolStripMenuItem
            // 
            this.employeesInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginAsToolStripMenuItem});
            this.employeesInformationToolStripMenuItem.Name = "employeesInformationToolStripMenuItem";
            this.employeesInformationToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.employeesInformationToolStripMenuItem.Text = "Employees Information";
            this.employeesInformationToolStripMenuItem.Click += new System.EventHandler(this.employeesInformationToolStripMenuItem_Click);
            // 
            // loginAsToolStripMenuItem
            // 
            this.loginAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.cashierToolStripMenuItem,
            this.workerToolStripMenuItem});
            this.loginAsToolStripMenuItem.Name = "loginAsToolStripMenuItem";
            this.loginAsToolStripMenuItem.Size = new System.Drawing.Size(187, 30);
            this.loginAsToolStripMenuItem.Text = "Login As";
            this.loginAsToolStripMenuItem.Click += new System.EventHandler(this.loginAsToolStripMenuItem_Click_1);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // cashierToolStripMenuItem
            // 
            this.cashierToolStripMenuItem.Name = "cashierToolStripMenuItem";
            this.cashierToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.cashierToolStripMenuItem.Text = "Cashier";
            // 
            // workerToolStripMenuItem
            // 
            this.workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            this.workerToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.workerToolStripMenuItem.Text = "Worker";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeInformationToolStripMenuItem});
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(79, 30);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // storeInformationToolStripMenuItem
            // 
            this.storeInformationToolStripMenuItem.Name = "storeInformationToolStripMenuItem";
            this.storeInformationToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.storeInformationToolStripMenuItem.Text = "Store Information";
            this.storeInformationToolStripMenuItem.Click += new System.EventHandler(this.storeInformationToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expensesInformationToolStripMenuItem});
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(118, 30);
            this.expensesToolStripMenuItem.Text = "Expenses";
            // 
            // expensesInformationToolStripMenuItem
            // 
            this.expensesInformationToolStripMenuItem.Name = "expensesInformationToolStripMenuItem";
            this.expensesInformationToolStripMenuItem.Size = new System.Drawing.Size(319, 30);
            this.expensesInformationToolStripMenuItem.Text = "Expenses Information";
            this.expensesInformationToolStripMenuItem.Click += new System.EventHandler(this.expensesInformationToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersInformationToolStripMenuItem});
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(112, 30);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // suppliersInformationToolStripMenuItem
            // 
            this.suppliersInformationToolStripMenuItem.Name = "suppliersInformationToolStripMenuItem";
            this.suppliersInformationToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.suppliersInformationToolStripMenuItem.Text = "Suppliers Information";
            this.suppliersInformationToolStripMenuItem.Click += new System.EventHandler(this.suppliersInformationToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentInformationToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // paymentInformationToolStripMenuItem
            // 
            this.paymentInformationToolStripMenuItem.Name = "paymentInformationToolStripMenuItem";
            this.paymentInformationToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.paymentInformationToolStripMenuItem.Text = "Payment Information";
            this.paymentInformationToolStripMenuItem.Click += new System.EventHandler(this.paymentInformationToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaryInformationToolStripMenuItem});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(91, 30);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // salaryInformationToolStripMenuItem
            // 
            this.salaryInformationToolStripMenuItem.Name = "salaryInformationToolStripMenuItem";
            this.salaryInformationToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.salaryInformationToolStripMenuItem.Text = "Salary Information";
            this.salaryInformationToolStripMenuItem.Click += new System.EventHandler(this.salaryInformationToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Wide Latin", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(802, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 54);
            this.label6.TabIndex = 46;
            this.label6.Text = "🔙";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.promotionsToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.transactionDetailToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 34);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(880, 34);
            this.menuStrip2.TabIndex = 47;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productInformationToolStripMenuItem});
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // productInformationToolStripMenuItem
            // 
            this.productInformationToolStripMenuItem.Name = "productInformationToolStripMenuItem";
            this.productInformationToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.productInformationToolStripMenuItem.Text = "Product Information";
            this.productInformationToolStripMenuItem.Click += new System.EventHandler(this.productInformationToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryInformationToolStripMenuItem});
            this.categoryToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(119, 30);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // categoryInformationToolStripMenuItem
            // 
            this.categoryInformationToolStripMenuItem.Name = "categoryInformationToolStripMenuItem";
            this.categoryInformationToolStripMenuItem.Size = new System.Drawing.Size(320, 30);
            this.categoryInformationToolStripMenuItem.Text = "Category Information";
            this.categoryInformationToolStripMenuItem.Click += new System.EventHandler(this.categoryInformationToolStripMenuItem_Click);
            // 
            // promotionsToolStripMenuItem
            // 
            this.promotionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promotionInformationToolStripMenuItem});
            this.promotionsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotionsToolStripMenuItem.Name = "promotionsToolStripMenuItem";
            this.promotionsToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.promotionsToolStripMenuItem.Text = "Promotions";
            // 
            // promotionInformationToolStripMenuItem
            // 
            this.promotionInformationToolStripMenuItem.Name = "promotionInformationToolStripMenuItem";
            this.promotionInformationToolStripMenuItem.Size = new System.Drawing.Size(334, 30);
            this.promotionInformationToolStripMenuItem.Text = "Promotion Information";
            this.promotionInformationToolStripMenuItem.Click += new System.EventHandler(this.promotionInformationToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionInformationToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // transactionInformationToolStripMenuItem
            // 
            this.transactionInformationToolStripMenuItem.Name = "transactionInformationToolStripMenuItem";
            this.transactionInformationToolStripMenuItem.Size = new System.Drawing.Size(346, 30);
            this.transactionInformationToolStripMenuItem.Text = "Transaction Information";
            this.transactionInformationToolStripMenuItem.Click += new System.EventHandler(this.transactionInformationToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderInformationToolStripMenuItem});
            this.orderToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(89, 30);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // orderInformationToolStripMenuItem
            // 
            this.orderInformationToolStripMenuItem.Name = "orderInformationToolStripMenuItem";
            this.orderInformationToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.orderInformationToolStripMenuItem.Text = "Order Information";
            this.orderInformationToolStripMenuItem.Click += new System.EventHandler(this.orderInformationToolStripMenuItem_Click);
            // 
            // transactionDetailToolStripMenuItem
            // 
            this.transactionDetailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionDetailInformationToolStripMenuItem});
            this.transactionDetailToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDetailToolStripMenuItem.Name = "transactionDetailToolStripMenuItem";
            this.transactionDetailToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.transactionDetailToolStripMenuItem.Text = "TransactionDetail";
            // 
            // transactionDetailInformationToolStripMenuItem
            // 
            this.transactionDetailInformationToolStripMenuItem.Name = "transactionDetailInformationToolStripMenuItem";
            this.transactionDetailInformationToolStripMenuItem.Size = new System.Drawing.Size(403, 30);
            this.transactionDetailInformationToolStripMenuItem.Text = "transactionDetail Information";
            this.transactionDetailInformationToolStripMenuItem.Click += new System.EventHandler(this.transactionDetailInformationToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.Silver;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.productimageToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(880, 34);
            this.menuStrip3.TabIndex = 48;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryInformationToolStripMenuItem});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // inventoryInformationToolStripMenuItem
            // 
            this.inventoryInformationToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryInformationToolStripMenuItem.Name = "inventoryInformationToolStripMenuItem";
            this.inventoryInformationToolStripMenuItem.Size = new System.Drawing.Size(325, 30);
            this.inventoryInformationToolStripMenuItem.Text = "Inventory Information";
            this.inventoryInformationToolStripMenuItem.Click += new System.EventHandler(this.inventoryInformationToolStripMenuItem_Click);
            // 
            // productimageToolStripMenuItem
            // 
            this.productimageToolStripMenuItem.Name = "productimageToolStripMenuItem";
            this.productimageToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.productimageToolStripMenuItem.Text = "Productimage";
            this.productimageToolStripMenuItem.Click += new System.EventHandler(this.productimageToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 596);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginAsToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryInformationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailInformationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productimageToolStripMenuItem;
        //  private EventHandler loginAsToolStripMenuItem_Click;
    }
}