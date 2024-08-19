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
    public partial class CategoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to add this Category", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("insert into tbCat (CatName) values(@CatName)", con);
                    cmd.Parameters.AddWithValue("@CatName", txtCatName.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Clear();
                }
            }
            catch(SqlException ex) { MessageBox.Show(ex.Message); }

        }

        public void Clear() {
            txtCatName.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You want to update this Category", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("update tbCat set CatName='"+txtCatName.Text+"'where CatId="+lbCatid.Text+"",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Clear();
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
