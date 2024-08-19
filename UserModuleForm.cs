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
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassWd.Text != txtRePw.Text)
                {
                    MessageBox.Show("Retype password Missmatch please check the password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are sure to save this user", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("insert into tbUser (UserName,FullName,Password,PhNo,Action)values(@UserName,@FullName,@Password,@PhNo,'"+ComboAction.Text+"')", con);
                    cmd.Parameters.AddWithValue("@UserName", txtUName.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassWd.Text);

                    cmd.Parameters.AddWithValue("@PhNo", txtPnum.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();

                    //UserForm load = new UserForm();
                    //load.LoadUser();
                    clear();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtPnum.Clear();
            txtUName.Clear();
            txtPassWd.Clear();
            txtFName.Clear();
            txtRePw.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtPassWd.Text != txtRePw.Text)
            {
                MessageBox.Show("Retype password Missmatch please check the password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are sure to Update this user", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("update tbUser set  FullName=@FullName,Password=@Password,PhNo=@PhNo where UserName Like '" + txtUName.Text + "'", con);

                cmd.Parameters.AddWithValue("@FullName", txtFName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassWd.Text);
               
                cmd.Parameters.AddWithValue("@PhNo", txtPnum.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();

             
               
                clear();
                this.Dispose();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}