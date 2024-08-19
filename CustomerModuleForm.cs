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
    public partial class CustomerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Are you Sure To Save this Customer", "Confirmation report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("insert into tbCustomer (Cname,Cphone) values(@Cname,@Cphone)", con);
                    cmd.Parameters.AddWithValue("@Cname", txtCName.Text);
                    cmd.Parameters.AddWithValue("@Cphone", txtCphone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    clear();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            txtCName.Clear();
            txtCphone.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            lbCid.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure To Update this Customer", "Confirmation report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("update  tbCustomer set Cname=@Cname,Cphone=@Cphone where Cid like " + lbCid.Text + "", con);
                    cmd.Parameters.AddWithValue("@Cname", txtCName.Text);
                    cmd.Parameters.AddWithValue("@Cphone", txtCphone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    clear();
                    lbCid.Enabled = false;
                    this.Dispose();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void txtCName_KeyDown(object sender, KeyEventArgs e)
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

