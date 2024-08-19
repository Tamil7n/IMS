using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management
{
    public partial class MainMenu : Form
    {
        public String ActionName;
       
        public MainMenu(string Role)
        {
            InitializeComponent();
            ActionName = Role;
            txtRoleStatus.Text = Role;
            Settings();
            
        }
        private new Form ActiveForm = null;
        public void Settings()
        {
            if (ActionName == "ADMIN")
            {
                userButtons1.Visible = true;
            }
            else { userButtons1.Visible = false; }
        }
     

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        
       
        private void OpenChildform(Form Childform)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
           
            ActiveForm = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            PanelMain.Tag = Childform;
            PanelMain.Controls.Add(Childform);
            Childform.BringToFront();
            
            Childform.Show();
        }
        private void userButtons1_Click(object sender, EventArgs e)
        {
         
           OpenChildform(new ProductForm(ActionName));
            
        }
        //Load Buttons
        //public  DataSet LoadButtons() {
        //    var Ds = new DataSet();
        //    try
        //    {
        //        con.Open();
        //        SqlDataAdapter DA = new SqlDataAdapter("Select * From AccessTb where Roll='ADMIN'",con);
        //        SqlCommandBuilder cmd = new SqlCommandBuilder(DA);
               
        //        DA.Fill(Ds);
        //        con.Close();
        //    }catch(SqlException Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //    return Ds;
        //}
        
        private void btnUsers_Click(object sender, EventArgs e)
        {
           OpenChildform(new UserForm(ActionName));
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
           OpenChildform(new CustomerForm(ActionName));
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildform(new CategoryForm(ActionName));
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildform(new OrderForm(ActionName));
        }

        private void userButtons1_Click_1(object sender, EventArgs e)
        {
            
            OpenChildform(new Settings());
           
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         

        }
    }
}
