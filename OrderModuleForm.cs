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
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataReader Dr;
       
        string t = "";
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
            Orderitem();
        }
        
        public void LoadCustomer()
        {
           
            int i = 0;
            dgvCustomer.Rows.Clear();
            cmd = new SqlCommand("select * from tbCustomer where Concat(Cid,Cname) like '%" + txtCusSearch.Text + "%' and IsDeleted=0", con);
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString());
            }
            Dr.Close();
            con.Close();
        }
        public void LoadProduct()
        {
          
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand("Select * From tbProduct where Concat(Pname,Pqty,Pprice,Pdesc,Pcate) like '%" + txtProdSearch.Text + "%' and Deleted=0", con);
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString(), Dr[2].ToString(), Dr[3].ToString(), Dr[4].ToString(), Dr[5].ToString());

            }
            Dr.Close();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCusSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtProdSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t = t + "a";
            txtCid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCname.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        int qty = 0;
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t = t + "b";
            txtProdId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPprice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            qty = Convert.ToInt16(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtTotal.Text = (Convert.ToInt16(NumLimit.Value) * Convert.ToInt16(txtPprice.Text)).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(NumLimit.Value) > qty)
            {
                DialogResult result = MessageBox.Show("Available Product Only " + qty + "Please Order Product With in Quantity", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    NumLimit.Value = 1;
                }
                return;
            }
            txtTotal.Text = (Convert.ToInt16(NumLimit.Value) * Convert.ToInt16(txtPprice.Text)).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (t == "ab" || t == "ba")
            {

                try
                {

                    cmd = new SqlCommand("insert into tbOrder (Odate,Pid,Cid,Qty,Price,Total)values(@Odate,@Pid,@Cid,@Qty,@Price,@Total)", con);
                    cmd.Parameters.AddWithValue("@Odate", OrderDate.Value);
                    cmd.Parameters.AddWithValue("@Pid", int.Parse(txtProdId.Text));
                    cmd.Parameters.AddWithValue("@Cid", int.Parse(txtCid.Text));
                    cmd.Parameters.AddWithValue("@Qty", NumLimit.Value);
                    cmd.Parameters.AddWithValue("@Price", int.Parse(txtPprice.Text));
                    cmd.Parameters.AddWithValue("@Total", int.Parse(txtTotal.Text));
                    int AvailableLimit = (int)(qty - NumLimit.Value);
                    cmd2 = new SqlCommand("Update  tbProduct set Pqty=" + AvailableLimit + " Where pid=" + txtProdId.Text + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    LoadProduct();
                    clear();
                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { t = ""; }
            }
            else if (t == "a")
            {
                MessageBox.Show("Please Select Product Id from Product Table");
            }
            else if (t == "b")
            {
                MessageBox.Show("Please Select Customer details from Customer table");
            }
            else
            {
                MessageBox.Show("Please select Customer And Product Details from responsive Table");
            }
        }
public void clear()
        {
            txtOid.Text = "";
            txtCid.Clear();
            txtCname.Clear();
            txtCusSearch.Clear();
            txtPName.Clear();
            txtPprice.Clear();
            txtProdId.Clear();
            txtProdSearch.Clear();
            txtTotal.Clear();
      
            OrderDate.ResetText();

        }
        public void Orderitem()
        {
            txtCid.Enabled = false;
            txtCname.Enabled = false;
            txtOid.Enabled = false;
            txtPName.Enabled = false;
            txtPprice.Enabled = false;
            txtProdId.Enabled = false;
            txtTotal.Enabled = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("You Want to Change this Order ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("Update tbOrder set Odate=@Odate,Pid=@Pid,Cid=@Cid,Qty=@Qty,Price=@Price,Total=@Total where Oid=", con);
                        cmd.Parameters.AddWithValue("@Odate", OrderDate.Value);
                        cmd.Parameters.AddWithValue("@Pid", int.Parse(txtProdId.Text));
                        cmd.Parameters.AddWithValue("@Cid", int.Parse(txtCid.Text));
                        cmd.Parameters.AddWithValue("@Qty", NumLimit.Value);
                        cmd.Parameters.AddWithValue("@Price", int.Parse(txtPprice.Text));
                        cmd.Parameters.AddWithValue("@Total", int.Parse(txtTotal.Text));
                        cmd.Parameters.AddWithValue("@Oid", int.Parse(txtOid.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Dispose(); LoadCustomer();
                        LoadProduct();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtCid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
        }
    }
}
