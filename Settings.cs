using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_management
{

    public partial class Settings : Form
    {
        public bool Ckval;
        public bool newItem;
        public bool Additem;
        public bool EditItem;
        public bool DelItem;
        public bool NewCus;
        public bool AddCus;
        public bool EditCus;
        public bool DelCus;
        public bool NewCat;
        public bool AddCat;
        public bool EditCat;
        public bool DelCat;
        public bool NewUser;
        public bool AddUser;
        public bool EditUser;
        public bool DelUser;
        public bool EditOrder;
        public bool DelOrder;
        public Panel Actpan;
        public Button btntemp;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public Settings()
        {
            InitializeComponent();
            LoadPanel();
        }
        public void LoadPanel()
        {
            panCategory.Visible = false;
            panUser.Visible = false;
            PanOrder.Visible = false;
            ProductPanel.Visible = false;
            Customerpanel.Visible = false;
        }
        public void RELoad()
        {
            btnCategoryAccess.Enabled = true;
            btnCustomerAccess.Enabled = true;
            BtnProductAccess.Enabled = true;
            User.Enabled = true;
            btnOrder.Enabled = true;
       
        }
        public void ActPanel(Object btnact)
        {
            try
            {
                btntemp = (Button)btnact;
                if (Actpan.Visible == false)
                {
                    Actpan.Visible = true;
                    Actpan.BringToFront();
                    LoadBtns();
                    btntemp.Enabled = true;

                }
                else { Actpan.Visible = false;
                    RELoad();
                }
               

            }
            catch { }
            finally
            {
            }



        }
        public void LoadBtns()
        {
            btnCategoryAccess.Enabled = false;
            btnCustomerAccess.Enabled = false;
            BtnProductAccess.Enabled = false;
            User.Enabled = false;
            btnOrder.Enabled = false;

        }

        public Button Actbtn;
        public CheckBox ckb;
        public bool ActCkbox(Object CkAct)
        {
            ckb = (CheckBox)CkAct;
            //ProductForm AddItem = new ProductForm();
            if (ckb.Checked)
            {
                Ckval = true;
            }
            else { Ckval = false; }

            return Ckval;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void NewProduct_CheckedChanged(object sender, EventArgs e)
        {
            newItem = ActCkbox(sender);
        }

        private void AddProduct_CheckedChanged(object sender, EventArgs e)
        {
            Additem = ActCkbox(sender);
        }

        private void EditProduct_CheckedChanged(object sender, EventArgs e)
        {
            EditItem = ActCkbox(sender);
        }

        private void DeleteProduct_CheckedChanged(object sender, EventArgs e)
        {
            DelItem = ActCkbox(sender);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Insert into AccessTb values('" + txtRoll.Text.ToUpper() + "','" + newItem + "','" + Additem + "','" + EditItem + "','" + DelItem + "','" + NewCat + "','" + AddCat + "','" + EditCat + "','" + DelCat + "','" + NewCus + "','" + AddCus + "','" + EditCus + "','" + DelCus + "','" + NewUser + "','" + AddUser + "','" + EditUser + "','" + DelUser + "','" + EditOrder + "','" + DelOrder + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(txtRoll.Text+" Added SuccessFully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void BtnProductAccess_Click(object sender, EventArgs e)
        {
            Actpan = ProductPanel;
            ActPanel(sender);
            //ProductPanel.Visible = true;

        }

        private void btnCustomerAccess_Click(object sender, EventArgs e)
        {
            Actpan = Customerpanel;
            ActPanel(sender);
            //Customerpanel.Visible = true;
        }

        private void btnCategoryAccess_Click(object sender, EventArgs e)
        {
            Actpan = panCategory;
            ActPanel(sender);
        }

        private void User_Click(object sender, EventArgs e)
        {
            Actpan = panUser;
            ActPanel(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        { Actpan = PanOrder;
            ActPanel(sender);
            }
            
            
    

        private void ProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewProduct_CheckedChanged_1(object sender, EventArgs e)
        {
            newItem = ActCkbox(sender);
        }

        private void AddProduct_CheckedChanged_1(object sender, EventArgs e)
        {
            Additem = ActCkbox(sender);

        }

        private void EditProduct_CheckedChanged_1(object sender, EventArgs e)
        {
            EditItem = ActCkbox(sender);
        }

        private void DeleteProduct_CheckedChanged_1(object sender, EventArgs e)
        {
            DelItem = ActCkbox(sender);
        }

        private void ckNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            NewCus = ActCkbox(sender);
        }

        private void ckAddCustomer_CheckedChanged(object sender, EventArgs e)
        {
            AddCus = ActCkbox(sender);
        }

        private void ckEditCustomer_CheckedChanged(object sender, EventArgs e)
        {
            EditCus = ActCkbox(sender);
        }

        private void ckDeleteCustomer_CheckedChanged(object sender, EventArgs e)
        {
            DelCus = ActCkbox(sender);
        }

        private void ckNewCategory_CheckedChanged(object sender, EventArgs e)
        {
            NewCat = ActCkbox(sender);
        }

        private void ckAddCategory_CheckedChanged(object sender, EventArgs e)
        {
            AddCat = ActCkbox(sender);
        }

        private void ckEditCategory_CheckedChanged(object sender, EventArgs e)
        {
            EditCat = ActCkbox(sender);

        }

        private void ckDeleteCategory_CheckedChanged(object sender, EventArgs e)
        {
            DelCat = ActCkbox(sender);
        }

        private void ckNewUser_CheckedChanged(object sender, EventArgs e)
        {
           NewUser = ActCkbox(sender);
        }

        private void ckAddUser_CheckedChanged(object sender, EventArgs e)
        {
            AddUser = ActCkbox(sender);
        }

        private void ckEditUser_CheckedChanged(object sender, EventArgs e)
        {
            EditUser = ActCkbox(sender);
        }

        private void ckdeleteUser_CheckedChanged(object sender, EventArgs e)
        {
            DelUser = ActCkbox(sender);
        }

        private void ckEditOrder_CheckedChanged(object sender, EventArgs e)
        {
            EditOrder = ActCkbox(sender);
        }

        private void ckDeleteOrder_CheckedChanged(object sender, EventArgs e)
        {
            DelOrder = ActCkbox(sender);
        }
    }
}
