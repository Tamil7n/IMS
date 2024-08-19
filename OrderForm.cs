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
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Tamil selvan v\05.08.2024\inventory management\Inventory management\Inventory management\Database1.mdf;Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dr;
        string Cname = "";
        string Pname = "";
        string Price = "";
        bool DeleteButton;
        bool EditButton;
        string Roll;
        public OrderForm(string Role)
        {
            Roll = Role;
            InitializeComponent();
            loadOrder();
        }
        public void Loadbtns()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Select EditOrder,DelOrder From AccessTb Where Roll='"+Roll+"' ", con);
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {

                    DeleteButton = Convert.ToBoolean(Dr[0].ToString());
                    EditButton = Convert.ToBoolean(Dr[1].ToString());
                }
                Dr.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally { con.Close(); }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OrderModuleForm Order = new OrderModuleForm();
            Order.btnSave.Enabled = true;
            Order.btnUpdate.Enabled= false;
            
            Order.txtOid.Text= "";
            Order.ShowDialog();
        }
        public void loadOrder()
        {
            int i = 0;
            dgvOrder.Rows.Clear();
            cmd = new SqlCommand("select tod.Oid,tod.Odate,tod.Pid,tod.Cid,tod.Qty,tod.Total,tc.Cname,tp.Pname,tp.Pprice  from tbOrder Tod left join  tbCustomer Tc  on Tod.Cid=Tc.Cid left join tbProduct Tp on tod.Pid=tp.Pid where concat(tod.Odate,tod.Pid,tod.Cid,tod.Price,tod.Total) like '%" + txtOrderSearch.Text+"%' and Tod.Deleted=0", con);
            con.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                i++;
               
                dgvOrder.Rows.Add(i, Dr[0].ToString(), Dr[1].ToString(), Dr[2].ToString(), Dr[3].ToString(), Dr[4].ToString(), Dr[5].ToString());
            }
          
            Dr.Close();
            con.Close();
        }
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvOrder.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                if (EditButton == true)
                {
                    OrderModuleForm EditOrder = new OrderModuleForm();
                    EditOrder.OrderDate.Text = dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                    EditOrder.txtCid.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();



                    EditOrder.txtOid.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                    EditOrder.txtProdId.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                    //EditOrder.NumLimit.Value = int.Parse(dgvOrder.Rows[e.RowIndex].Cells[5].Value.ToString());
                    EditOrder.ShowDialog();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadOrder();
        }
    }
}
