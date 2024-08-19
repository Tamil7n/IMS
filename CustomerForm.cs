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
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dr;
        bool DeleteButton;
        bool EditButton;
        string Roll;
        public CustomerForm(string Role)
        {
            Roll = Role;
            InitializeComponent();
            loadCustomer();
            Loadbtns();
        }
        public void Loadbtns()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Select NewCus,AddCus,EditCus,DelCus From AccessTb where Roll='" + Roll + "' ", con);
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
        public void loadCustomer()
        {
            int i=0;
            dgvCustomer.Rows.Clear();
            cmd = new SqlCommand("Select * from tbCustomer where IsDeleted=0", con);
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read()) 
            {
                i++;
                dgvCustomer.Rows.Add(i, int.Parse(Dr[0].ToString()), Dr[1].ToString(), Dr[2].ToString());
            }
            Dr.Close();
            con.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CustomerModuleForm Addcustomer = new CustomerModuleForm();
            Addcustomer.btnUpdate.Enabled = false;
            Addcustomer.btnSave.Enabled = true;
           Addcustomer. ShowDialog();
            loadCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                if (EditButton == true)
                {
                    CustomerModuleForm EditCustomer = new CustomerModuleForm();
                    EditCustomer.lbCid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                    EditCustomer.txtCName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                    EditCustomer.txtCphone.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();

                    EditCustomer.btnSave.Enabled = false;
                    EditCustomer.btnUpdate.Enabled = true;
                    EditCustomer.lbCid.Visible = true;
                    EditCustomer.ShowDialog();
                    loadCustomer();
                }
                else { MessageBox.Show("Access Denied"); } 
            }
            else if (colname == "Delete")
            {
                if (DeleteButton == true)
                {
                    if (MessageBox.Show("You want to Delete this customer :" + dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString() + ".", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("upDate  tbCustomer set Isdeleted=1 where Cid like " + int.Parse(dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString()) + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        loadCustomer();
                    }
                }
                else { MessageBox.Show("Access Denied"); }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
