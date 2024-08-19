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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dr;
        bool DeleteButton;
        bool EditButton;
        string Roll;

        public ProductForm(string Role)
        {
            Roll = Role;
            InitializeComponent();
            LoadProduct();
            Loadbtns();
        }
        public void Loadbtns()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select NProd,DelProd,EditProd from AccessTb where Roll='"+Roll+"' ", con);
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    btnAddProduct.Enabled = Convert.ToBoolean(Dr[0].ToString());
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
        public void LoadProduct()
        {
            dgvProduct.Rows.Clear();
            int i = 0;
            cmd = new SqlCommand("Select * from tbProduct where Concat(Pname,Pqty,Pprice,Pdesc,Pcate) like '%"+txtSearch.Text+"%' and  Deleted=0", con);
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            { i++;
                dgvProduct.Rows.Add(i,Dr[0].ToString(),Dr[1].ToString(),Dr[2].ToString(), Dr[3].ToString(), Dr[4].ToString(), Dr[5].ToString());
            }
            Dr.Close();
            con.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductModuleForm AddProduct =new ProductModuleForm();
            AddProduct.btnSave.Enabled = true;
            AddProduct.btnUpdate.Enabled = false;
            AddProduct.ShowDialog();
            LoadProduct();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            {
                if (colName == "Edit")
                {
                    if (EditButton == true)
                    {
                        ProductModuleForm Editprod = new ProductModuleForm();
                        Editprod.Lbpid.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Editprod.txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Editprod.txtQty.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                        Editprod.txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                        Editprod.txtdesc.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                        Editprod.ComboCat.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                        Editprod.btnSave.Enabled = false;
                        Editprod.btnUpdate.Enabled = true;
                        Editprod.ShowDialog();

                        LoadProduct();
                    }
                    else { MessageBox.Show("Access Denied"); }
                }
                else if (colName == "Delete")
                {
                    if (DeleteButton == true)
                    {
                        if (MessageBox.Show("you Want to Delete this Product", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("update  tbProduct set Deleted=1 Where Pid=" + dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            LoadProduct();
                        }
                    }
                    else { MessageBox.Show("Access Denied"); }
                }
            } }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
