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
    public partial class Form1 : Form
    {
       public string Role;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataReader Dr;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtUn.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void btnLg_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtUn.Text != "")
            {


                cmd = new SqlCommand("Select Action from tbUser where UserName='" + txtUn.Text + "' and Password='" + txtPass.Text + "'", con);
                con.Open();
                Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                      Role = Dr["Action"].ToString();
                    MainMenu Login = new MainMenu(Role);
                    Login.FormClosing += (s, args) => this.Close();
                    Login.Show();
                    this.Hide();
                    Dr.Close();
                    con.Close();
                }

                else
                {
                    if (MessageBox.Show("Please Check User Name or Password", "Authendication Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        txtPass.Clear();
                        txtUn.Clear();
                        txtUn.Focus();

                    }
                }
                Dr.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Check User Name or Password", "Authendication Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }


        }

        private void txtUn_KeyDown_1(object sender, KeyEventArgs e)
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

