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
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCombo();
            
        }
        public void LoadCombo()
        {
            cmd = new SqlCommand("Select CatName from tbCat ",con);
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                ComboCat.Items.Add(Dr[0].ToString());
            }
            Dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("You Want to Add this Product", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("insert into tbProduct (Pname,Pqty,Pprice,Pdesc,Pcate) values(@Pname,@Pqty,@Pprice,@Pdesc,@Pcate)",con);
                    cmd.Parameters.AddWithValue("@Pname", txtPName.Text);
                    cmd.Parameters.AddWithValue("@Pqty", txtQty.Text);
                    cmd.Parameters.AddWithValue("@Pprice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@Pdesc", txtdesc.Text);
                    cmd.Parameters.AddWithValue("@Pcate", ComboCat.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("You Want toUpdate this Product", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("update tbProduct set Pname=@Pname,Pqty=@Pqty,Pprice=@Pprice,Pdesc=@Pdesc,Pcate=@Pcate Where Pid="+Lbpid.Text+" ", con);
                    cmd.Parameters.AddWithValue("@Pname", txtPName.Text);
                    cmd.Parameters.AddWithValue("@Pqty", txtQty.Text);
                    cmd.Parameters.AddWithValue("@Pprice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@Pdesc", txtdesc.Text);
                    cmd.Parameters.AddWithValue("@Pcate", ComboCat.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Dispose();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPName_KeyDown(object sender, KeyEventArgs e)
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
