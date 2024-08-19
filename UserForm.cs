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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dr;
        bool DeleteButton;
        bool EditButton;
        string Roll;
        public UserForm(string Role)
        {
            InitializeComponent();
            Roll = Role;
            LoadUser();
            Loadbtns();
        }
        public void Loadbtns()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Select NUser,EditUser,DelUser From AccessTb where Roll='" + Roll + "'  ", con);
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    btnAddUser.Enabled = Convert.ToBoolean(Dr[0].ToString());
                    EditButton = Convert.ToBoolean(Dr[1].ToString());
                    DeleteButton = Convert.ToBoolean(Dr[2].ToString());
                }
                Dr.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally { con.Close(); }
        }
        public void LoadUser() 
        {
           
            try
            {
                int i = 0;
                dgvUser.Rows.Clear();
                cmd = new SqlCommand("Select * from tbUser where deleted=0",con);
                con.Open();
               Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    i++;
                    dgvUser.Rows.Add(i,Dr[0].ToString(),Dr[1].ToString(),Dr[2].ToString(),Dr[3].ToString());
                }
                Dr.Close();
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserModuleForm newUser = new UserModuleForm();
            newUser.btnSave.Enabled = true;
            newUser.btnUpdate.Enabled = false;
            newUser.ShowDialog();
            LoadUser();
           
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                if (EditButton == true)
                {
                   
                        UserModuleForm EditUser = new UserModuleForm();
                        EditUser.txtUName.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                        EditUser.txtFName.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                        EditUser.txtPassWd.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                        EditUser.txtPnum.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();

                        EditUser.btnSave.Enabled = false;
                        EditUser.btnUpdate.Enabled = true;
                        EditUser.txtUName.Enabled = false;
                        EditUser.ShowDialog();
                        LoadUser();
                    
                }
            }
            else if (colName == "Delete")
            {
                if (DeleteButton == true)
                {
                    if (MessageBox.Show("Are you sure you want to Delete this User :" + dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + ",", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("update  tbUser set  Deleted=1  Where UserName ='" + dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        LoadUser();

                    }
                }
            }
        }
    }
}
