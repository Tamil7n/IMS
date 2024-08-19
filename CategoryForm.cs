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
    public partial class CategoryForm : Form
    {
       
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dr;
        bool DeleteButton;
        bool EditButton;
        public string Roll;
        public CategoryForm(string Role)
        {
            Roll = Role;

            InitializeComponent();
            LoadCategory();
            Loadbtns();
        }
        public void Loadbtns()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Select NCat,AddCat,EditCat,DelCat From AccessTb where Roll='" + Roll + "'  ", con);
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    btnAddUser.Enabled = Convert.ToBoolean(Dr[0].ToString());
                    DeleteButton = Convert.ToBoolean(Dr[1].ToString());
                    EditButton = Convert.ToBoolean(Dr[2].ToString());
                }
                Dr.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally { con.Close(); }
        }
        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cmd = new SqlCommand("Select * from tbCat where Deleted =0", con);
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString());
            }
            Dr.Close();
            con.Close();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                if (EditButton == true)
                {
                    CategoryModuleForm EditCategory = new CategoryModuleForm();
                    EditCategory.lbCatid.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                    EditCategory.txtCatName.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();

                    EditCategory.btnSave.Enabled = false;
                    EditCategory.btnUpdate.Enabled = true;
                    EditCategory.ShowDialog();
                    LoadCategory();
                }
                else { MessageBox.Show("Access Denied"); }
            }
            else if (colName == "Delete")
            {
                if (DeleteButton==true) {
                    if (MessageBox.Show("Click Yes for delate Particular Category", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("update  tbCat set Deleted=1 where CatId =" + dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        LoadCategory();
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
                
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CategoryModuleForm AddCategory = new CategoryModuleForm();
            
            AddCategory.btnSave.Enabled = true;
            AddCategory.btnUpdate.Enabled = false;
            AddCategory.ShowDialog();
            LoadCategory();

        }
    }
}
