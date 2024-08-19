
namespace Inventory_management
{
    partial class Settings
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.DeleteProduct = new System.Windows.Forms.CheckBox();
            this.AddProduct = new System.Windows.Forms.CheckBox();
            this.EditProduct = new System.Windows.Forms.CheckBox();
            this.NewProduct = new System.Windows.Forms.CheckBox();
            this.BtnProductAccess = new System.Windows.Forms.Button();
            this.btnCustomerAccess = new System.Windows.Forms.Button();
            this.Customerpanel = new System.Windows.Forms.Panel();
            this.ckDeleteCustomer = new System.Windows.Forms.CheckBox();
            this.ckAddCustomer = new System.Windows.Forms.CheckBox();
            this.ckEditCustomer = new System.Windows.Forms.CheckBox();
            this.ckNewCustomer = new System.Windows.Forms.CheckBox();
            this.btnCategoryAccess = new System.Windows.Forms.Button();
            this.panCategory = new System.Windows.Forms.Panel();
            this.ckDeleteCategory = new System.Windows.Forms.CheckBox();
            this.ckAddCategory = new System.Windows.Forms.CheckBox();
            this.ckEditCategory = new System.Windows.Forms.CheckBox();
            this.ckNewCategory = new System.Windows.Forms.CheckBox();
            this.User = new System.Windows.Forms.Button();
            this.panUser = new System.Windows.Forms.Panel();
            this.ckdeleteUser = new System.Windows.Forms.CheckBox();
            this.ckAddUser = new System.Windows.Forms.CheckBox();
            this.ckEditUser = new System.Windows.Forms.CheckBox();
            this.ckNewUser = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.PanOrder = new System.Windows.Forms.Panel();
            this.ckDeleteOrder = new System.Windows.Forms.CheckBox();
            this.ckEditOrder = new System.Windows.Forms.CheckBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductPanel.SuspendLayout();
            this.Customerpanel.SuspendLayout();
            this.panCategory.SuspendLayout();
            this.panUser.SuspendLayout();
            this.PanOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(431, 288);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Load";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.DeleteProduct);
            this.ProductPanel.Controls.Add(this.AddProduct);
            this.ProductPanel.Controls.Add(this.EditProduct);
            this.ProductPanel.Controls.Add(this.NewProduct);
            this.ProductPanel.Location = new System.Drawing.Point(354, 46);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(221, 228);
            this.ProductPanel.TabIndex = 5;
            this.ProductPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductPanel_Paint);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.AutoSize = true;
            this.DeleteProduct.Location = new System.Drawing.Point(62, 140);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(94, 17);
            this.DeleteProduct.TabIndex = 7;
            this.DeleteProduct.Text = "DeleteProduct";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.CheckedChanged += new System.EventHandler(this.DeleteProduct_CheckedChanged_1);
            // 
            // AddProduct
            // 
            this.AddProduct.AutoSize = true;
            this.AddProduct.Location = new System.Drawing.Point(62, 94);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(82, 17);
            this.AddProduct.TabIndex = 6;
            this.AddProduct.Text = "AddProduct";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.CheckedChanged += new System.EventHandler(this.AddProduct_CheckedChanged_1);
            // 
            // EditProduct
            // 
            this.EditProduct.AutoSize = true;
            this.EditProduct.Location = new System.Drawing.Point(62, 117);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(81, 17);
            this.EditProduct.TabIndex = 5;
            this.EditProduct.Text = "EditProduct";
            this.EditProduct.UseVisualStyleBackColor = true;
            this.EditProduct.CheckedChanged += new System.EventHandler(this.EditProduct_CheckedChanged_1);
            // 
            // NewProduct
            // 
            this.NewProduct.AutoSize = true;
            this.NewProduct.Location = new System.Drawing.Point(62, 71);
            this.NewProduct.Name = "NewProduct";
            this.NewProduct.Size = new System.Drawing.Size(88, 17);
            this.NewProduct.TabIndex = 4;
            this.NewProduct.Text = "New Product";
            this.NewProduct.UseVisualStyleBackColor = true;
            this.NewProduct.CheckedChanged += new System.EventHandler(this.NewProduct_CheckedChanged_1);
            // 
            // BtnProductAccess
            // 
            this.BtnProductAccess.Location = new System.Drawing.Point(147, 116);
            this.BtnProductAccess.Name = "BtnProductAccess";
            this.BtnProductAccess.Size = new System.Drawing.Size(75, 23);
            this.BtnProductAccess.TabIndex = 6;
            this.BtnProductAccess.Text = "Product";
            this.BtnProductAccess.UseVisualStyleBackColor = true;
            this.BtnProductAccess.Click += new System.EventHandler(this.BtnProductAccess_Click);
            // 
            // btnCustomerAccess
            // 
            this.btnCustomerAccess.Location = new System.Drawing.Point(147, 151);
            this.btnCustomerAccess.Name = "btnCustomerAccess";
            this.btnCustomerAccess.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerAccess.TabIndex = 7;
            this.btnCustomerAccess.Text = "Customer";
            this.btnCustomerAccess.UseVisualStyleBackColor = true;
            this.btnCustomerAccess.Click += new System.EventHandler(this.btnCustomerAccess_Click);
            // 
            // Customerpanel
            // 
            this.Customerpanel.Controls.Add(this.ckDeleteCustomer);
            this.Customerpanel.Controls.Add(this.ckAddCustomer);
            this.Customerpanel.Controls.Add(this.ckEditCustomer);
            this.Customerpanel.Controls.Add(this.ckNewCustomer);
            this.Customerpanel.Location = new System.Drawing.Point(352, 48);
            this.Customerpanel.Name = "Customerpanel";
            this.Customerpanel.Size = new System.Drawing.Size(221, 234);
            this.Customerpanel.TabIndex = 8;
            // 
            // ckDeleteCustomer
            // 
            this.ckDeleteCustomer.AutoSize = true;
            this.ckDeleteCustomer.Location = new System.Drawing.Point(62, 140);
            this.ckDeleteCustomer.Name = "ckDeleteCustomer";
            this.ckDeleteCustomer.Size = new System.Drawing.Size(104, 17);
            this.ckDeleteCustomer.TabIndex = 7;
            this.ckDeleteCustomer.Text = "Delete Customer";
            this.ckDeleteCustomer.UseVisualStyleBackColor = true;
            this.ckDeleteCustomer.CheckedChanged += new System.EventHandler(this.ckDeleteCustomer_CheckedChanged);
            // 
            // ckAddCustomer
            // 
            this.ckAddCustomer.AutoSize = true;
            this.ckAddCustomer.Location = new System.Drawing.Point(62, 94);
            this.ckAddCustomer.Name = "ckAddCustomer";
            this.ckAddCustomer.Size = new System.Drawing.Size(92, 17);
            this.ckAddCustomer.TabIndex = 6;
            this.ckAddCustomer.Text = "Add Customer";
            this.ckAddCustomer.UseVisualStyleBackColor = true;
            this.ckAddCustomer.CheckedChanged += new System.EventHandler(this.ckAddCustomer_CheckedChanged);
            // 
            // ckEditCustomer
            // 
            this.ckEditCustomer.AutoSize = true;
            this.ckEditCustomer.Location = new System.Drawing.Point(62, 117);
            this.ckEditCustomer.Name = "ckEditCustomer";
            this.ckEditCustomer.Size = new System.Drawing.Size(91, 17);
            this.ckEditCustomer.TabIndex = 5;
            this.ckEditCustomer.Text = "Edit Customer";
            this.ckEditCustomer.UseVisualStyleBackColor = true;
            this.ckEditCustomer.CheckedChanged += new System.EventHandler(this.ckEditCustomer_CheckedChanged);
            // 
            // ckNewCustomer
            // 
            this.ckNewCustomer.AutoSize = true;
            this.ckNewCustomer.Location = new System.Drawing.Point(62, 71);
            this.ckNewCustomer.Name = "ckNewCustomer";
            this.ckNewCustomer.Size = new System.Drawing.Size(95, 17);
            this.ckNewCustomer.TabIndex = 4;
            this.ckNewCustomer.Text = "New Customer";
            this.ckNewCustomer.UseVisualStyleBackColor = true;
            this.ckNewCustomer.CheckedChanged += new System.EventHandler(this.ckNewCustomer_CheckedChanged);
            // 
            // btnCategoryAccess
            // 
            this.btnCategoryAccess.Location = new System.Drawing.Point(147, 186);
            this.btnCategoryAccess.Name = "btnCategoryAccess";
            this.btnCategoryAccess.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryAccess.TabIndex = 8;
            this.btnCategoryAccess.Text = "Category";
            this.btnCategoryAccess.UseVisualStyleBackColor = true;
            this.btnCategoryAccess.Click += new System.EventHandler(this.btnCategoryAccess_Click);
            // 
            // panCategory
            // 
            this.panCategory.Controls.Add(this.ckDeleteCategory);
            this.panCategory.Controls.Add(this.ckAddCategory);
            this.panCategory.Controls.Add(this.ckEditCategory);
            this.panCategory.Controls.Add(this.ckNewCategory);
            this.panCategory.Location = new System.Drawing.Point(349, 43);
            this.panCategory.Name = "panCategory";
            this.panCategory.Size = new System.Drawing.Size(221, 228);
            this.panCategory.TabIndex = 9;
            // 
            // ckDeleteCategory
            // 
            this.ckDeleteCategory.AutoSize = true;
            this.ckDeleteCategory.Location = new System.Drawing.Point(62, 140);
            this.ckDeleteCategory.Name = "ckDeleteCategory";
            this.ckDeleteCategory.Size = new System.Drawing.Size(102, 17);
            this.ckDeleteCategory.TabIndex = 7;
            this.ckDeleteCategory.Text = "Delete Category";
            this.ckDeleteCategory.UseVisualStyleBackColor = true;
            this.ckDeleteCategory.CheckedChanged += new System.EventHandler(this.ckDeleteCategory_CheckedChanged);
            // 
            // ckAddCategory
            // 
            this.ckAddCategory.AutoSize = true;
            this.ckAddCategory.Location = new System.Drawing.Point(62, 94);
            this.ckAddCategory.Name = "ckAddCategory";
            this.ckAddCategory.Size = new System.Drawing.Size(90, 17);
            this.ckAddCategory.TabIndex = 6;
            this.ckAddCategory.Text = "Add Category";
            this.ckAddCategory.UseVisualStyleBackColor = true;
            this.ckAddCategory.CheckedChanged += new System.EventHandler(this.ckAddCategory_CheckedChanged);
            // 
            // ckEditCategory
            // 
            this.ckEditCategory.AutoSize = true;
            this.ckEditCategory.Location = new System.Drawing.Point(63, 117);
            this.ckEditCategory.Name = "ckEditCategory";
            this.ckEditCategory.Size = new System.Drawing.Size(89, 17);
            this.ckEditCategory.TabIndex = 5;
            this.ckEditCategory.Text = "Edit Category";
            this.ckEditCategory.UseVisualStyleBackColor = true;
            this.ckEditCategory.CheckedChanged += new System.EventHandler(this.ckEditCategory_CheckedChanged);
            // 
            // ckNewCategory
            // 
            this.ckNewCategory.AutoSize = true;
            this.ckNewCategory.Location = new System.Drawing.Point(62, 71);
            this.ckNewCategory.Name = "ckNewCategory";
            this.ckNewCategory.Size = new System.Drawing.Size(87, 17);
            this.ckNewCategory.TabIndex = 4;
            this.ckNewCategory.Text = "New Catgory";
            this.ckNewCategory.UseVisualStyleBackColor = true;
            this.ckNewCategory.CheckedChanged += new System.EventHandler(this.ckNewCategory_CheckedChanged);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(147, 221);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(75, 23);
            this.User.TabIndex = 9;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // panUser
            // 
            this.panUser.Controls.Add(this.ckdeleteUser);
            this.panUser.Controls.Add(this.ckAddUser);
            this.panUser.Controls.Add(this.ckEditUser);
            this.panUser.Controls.Add(this.ckNewUser);
            this.panUser.Location = new System.Drawing.Point(336, 48);
            this.panUser.Name = "panUser";
            this.panUser.Size = new System.Drawing.Size(221, 226);
            this.panUser.TabIndex = 10;
            // 
            // ckdeleteUser
            // 
            this.ckdeleteUser.AutoSize = true;
            this.ckdeleteUser.Location = new System.Drawing.Point(62, 140);
            this.ckdeleteUser.Name = "ckdeleteUser";
            this.ckdeleteUser.Size = new System.Drawing.Size(82, 17);
            this.ckdeleteUser.TabIndex = 7;
            this.ckdeleteUser.Text = "Delete User";
            this.ckdeleteUser.UseVisualStyleBackColor = true;
            this.ckdeleteUser.CheckedChanged += new System.EventHandler(this.ckdeleteUser_CheckedChanged);
            // 
            // ckAddUser
            // 
            this.ckAddUser.AutoSize = true;
            this.ckAddUser.Location = new System.Drawing.Point(62, 94);
            this.ckAddUser.Name = "ckAddUser";
            this.ckAddUser.Size = new System.Drawing.Size(70, 17);
            this.ckAddUser.TabIndex = 6;
            this.ckAddUser.Text = "Add User";
            this.ckAddUser.UseVisualStyleBackColor = true;
            this.ckAddUser.CheckedChanged += new System.EventHandler(this.ckAddUser_CheckedChanged);
            // 
            // ckEditUser
            // 
            this.ckEditUser.AutoSize = true;
            this.ckEditUser.Location = new System.Drawing.Point(63, 117);
            this.ckEditUser.Name = "ckEditUser";
            this.ckEditUser.Size = new System.Drawing.Size(69, 17);
            this.ckEditUser.TabIndex = 5;
            this.ckEditUser.Text = "Edit User";
            this.ckEditUser.UseVisualStyleBackColor = true;
            this.ckEditUser.CheckedChanged += new System.EventHandler(this.ckEditUser_CheckedChanged);
            // 
            // ckNewUser
            // 
            this.ckNewUser.AutoSize = true;
            this.ckNewUser.Location = new System.Drawing.Point(62, 71);
            this.ckNewUser.Name = "ckNewUser";
            this.ckNewUser.Size = new System.Drawing.Size(73, 17);
            this.ckNewUser.TabIndex = 4;
            this.ckNewUser.Text = "New User";
            this.ckNewUser.UseVisualStyleBackColor = true;
            this.ckNewUser.CheckedChanged += new System.EventHandler(this.ckNewUser_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(147, 256);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanOrder
            // 
            this.PanOrder.Controls.Add(this.ckDeleteOrder);
            this.PanOrder.Controls.Add(this.ckEditOrder);
            this.PanOrder.Location = new System.Drawing.Point(349, 46);
            this.PanOrder.Name = "PanOrder";
            this.PanOrder.Size = new System.Drawing.Size(221, 228);
            this.PanOrder.TabIndex = 11;
            // 
            // ckDeleteOrder
            // 
            this.ckDeleteOrder.AutoSize = true;
            this.ckDeleteOrder.Location = new System.Drawing.Point(62, 140);
            this.ckDeleteOrder.Name = "ckDeleteOrder";
            this.ckDeleteOrder.Size = new System.Drawing.Size(86, 17);
            this.ckDeleteOrder.TabIndex = 7;
            this.ckDeleteOrder.Text = "Delete Order";
            this.ckDeleteOrder.UseVisualStyleBackColor = true;
            this.ckDeleteOrder.CheckedChanged += new System.EventHandler(this.ckDeleteOrder_CheckedChanged);
            // 
            // ckEditOrder
            // 
            this.ckEditOrder.AutoSize = true;
            this.ckEditOrder.Location = new System.Drawing.Point(63, 117);
            this.ckEditOrder.Name = "ckEditOrder";
            this.ckEditOrder.Size = new System.Drawing.Size(73, 17);
            this.ckEditOrder.TabIndex = 5;
            this.ckEditOrder.Text = "Edit Order";
            this.ckEditOrder.UseVisualStyleBackColor = true;
            this.ckEditOrder.CheckedChanged += new System.EventHandler(this.ckEditOrder_CheckedChanged);
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(149, 85);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(100, 20);
            this.txtRoll.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Roll";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.panCategory);
            this.Controls.Add(this.panUser);
            this.Controls.Add(this.Customerpanel);
            this.Controls.Add(this.PanOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.User);
            this.Controls.Add(this.btnCategoryAccess);
            this.Controls.Add(this.btnCustomerAccess);
            this.Controls.Add(this.BtnProductAccess);
            this.Controls.Add(this.BtnSave);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            this.Customerpanel.ResumeLayout(false);
            this.Customerpanel.PerformLayout();
            this.panCategory.ResumeLayout(false);
            this.panCategory.PerformLayout();
            this.panUser.ResumeLayout(false);
            this.panUser.PerformLayout();
            this.PanOrder.ResumeLayout(false);
            this.PanOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Panel ProductPanel;
        public System.Windows.Forms.CheckBox DeleteProduct;
        public System.Windows.Forms.CheckBox AddProduct;
        public System.Windows.Forms.CheckBox EditProduct;
        public System.Windows.Forms.CheckBox NewProduct;
        private System.Windows.Forms.Button BtnProductAccess;
        public System.Windows.Forms.Panel Customerpanel;
        public System.Windows.Forms.CheckBox ckDeleteCustomer;
        public System.Windows.Forms.CheckBox ckAddCustomer;
        public System.Windows.Forms.CheckBox ckEditCustomer;
        public System.Windows.Forms.CheckBox ckNewCustomer;
        private System.Windows.Forms.Button btnCustomerAccess;
        private System.Windows.Forms.Button btnCategoryAccess;
        public System.Windows.Forms.Panel panCategory;
        public System.Windows.Forms.CheckBox ckDeleteCategory;
        public System.Windows.Forms.CheckBox ckAddCategory;
        public System.Windows.Forms.CheckBox ckEditCategory;
        public System.Windows.Forms.CheckBox ckNewCategory;
        private System.Windows.Forms.Button User;
        public System.Windows.Forms.Panel panUser;
        public System.Windows.Forms.CheckBox ckdeleteUser;
        public System.Windows.Forms.CheckBox ckAddUser;
        public System.Windows.Forms.CheckBox ckEditUser;
        public System.Windows.Forms.CheckBox ckNewUser;
        private System.Windows.Forms.Button btnOrder;
        public System.Windows.Forms.Panel PanOrder;
        public System.Windows.Forms.CheckBox ckDeleteOrder;
        public System.Windows.Forms.CheckBox ckEditOrder;
        public System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label label1;
    }
}