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

namespace KursovaZadacha
{
    public partial class NewCustomer : Form
    {
        

        public NewCustomer()
        {
            InitializeComponent();
        }

        


        private void btnNewContract_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer customer = new Customer();
            customer.Address = this.txtBoxAddress.Text;
            customer.Name = this.txtFNameLName.Text;

            if(this.rbtnJL_NewC.Checked){ customer.MyType = Convert.ToChar("0");}
            else{customer.MyType = Convert.ToChar("1");}

            if (this.rbtnMan_NewC.Checked) { customer.Sex = ("m"); }
            else { customer.Sex = ("w"); }

            customer.EGN = this.txtBoxEGN.Text;
            customer.E_mail = this.txtBoxMail.Text;
            customer.Tel = this.txtBoxPhone.Text;
            customer.CompanyName = this.txtBoxFirmName.Text;
            customer.Address = this.txtBoxAddress.Text;
            customer.BULSTAT = this.txtBoxBulstat.Text;

            
            frmNewContract frm1 = new frmNewContract(customer);
            frm1.MdiParent = this.MdiParent;
            frm1.Show();

          
        }

//TODO validaciq na EGN - 10 simvola


        private void btnExit_Click(object sender, EventArgs e)
        {
            txtFNameLName.Clear();
            txtBoxEGN.Clear();
            txtBoxFirmName.Clear();
            txtBoxBulstat.Clear();
            txtBoxAddress.Clear();
            txtBoxMail.Clear();
            txtBoxPhone.Clear();

            this.Close();



        }

        private void NewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rbtnJL_NewC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJL_NewC.Checked == true)
                {
                    rbtnJL_NewC.Checked = true;
                    rbtnFL_NewC.Checked = false;

                   
                    txtFNameLName.ReadOnly = true;
                    txtBoxEGN.ReadOnly = true;
                    txtBoxFirmName.ReadOnly = false;
                    txtBoxBulstat.ReadOnly = false;

                    rbtnMan_NewC.Enabled = false;
                    rbtnWaman_NewC.Enabled = false;

                }
                else
                {

                    rbtnJL_NewC.Checked = false;
                    rbtnFL_NewC.Checked = true;

                    txtBoxFirmName.ReadOnly = true;
                    txtBoxBulstat.ReadOnly = true;
                    txtFNameLName.ReadOnly = false;
                    txtBoxEGN.ReadOnly = false;
                }
        }

        private void rbtnFL_NewC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFL_NewC.Checked == true)
            {
                rbtnFL_NewC.Checked = true;
                rbtnJL_NewC.Checked = false;


                txtBoxFirmName.ReadOnly = true;
                txtBoxBulstat.ReadOnly = true;
                rbtnMan_NewC.Enabled = true;
                rbtnWaman_NewC.Enabled = true;
            }
            else
            {

                rbtnFL_NewC.Checked = false;
                rbtnJL_NewC.Checked = true;

                
                txtFNameLName.ReadOnly = true;
                txtBoxEGN.ReadOnly = true;
                rbtnMan_NewC.Enabled = false;
                rbtnWaman_NewC.Enabled = false;
            }
        }

        private void rbtnMan_NewC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMan_NewC.Checked == true)
            {
                rbtnMan_NewC.Checked = true;
                rbtnWaman_NewC.Checked = false;
            }
            else
            {

                rbtnMan_NewC.Checked = false;
                rbtnWaman_NewC.Checked = true;
            }
        }

        private void rbtnWaman_NewC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnWaman_NewC.Checked == true)
            {
                rbtnWaman_NewC.Checked = true;
                rbtnMan_NewC.Checked = false;
            }
            else
            {

                rbtnWaman_NewC.Checked = false;
                rbtnMan_NewC.Checked = true;
            }
        }

        public static SqlConnection CreateConection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=XXX-PC\SQLEXPRESS;Initial Catalog=iani;Integrated Security=True";
            return conn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = NewCustomer.CreateConection();
            using (connection) 
            {
                SqlCommand mycommand = new SqlCommand("sp_isertCustomer1", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_isertCustomer1";

               




                SqlParameter FL = new SqlParameter("@Customer_type", SqlDbType.Char);
                SqlParameter CL_EGN = new SqlParameter("@Customer_EGN_BULSTAT", SqlDbType.NVarChar);
                SqlParameter Fullname_nameCompany = new SqlParameter("@Customer_fullname", SqlDbType.NVarChar);

                if (this.rbtnJL_NewC.Checked)
                {
                    FL.Value = Convert.ToChar("0");
                    CL_EGN.Value = txtBoxBulstat.Text;
                    Fullname_nameCompany.Value = txtBoxFirmName.Text;
                }
                else
                {
                    FL.Value = Convert.ToChar("1");
                    CL_EGN.Value = txtBoxEGN.Text;
                    Fullname_nameCompany.Value = txtFNameLName.Text;
                }
                mycommand.Parameters.Add(FL);
                mycommand.Parameters.Add(CL_EGN);
                mycommand.Parameters.Add(Fullname_nameCompany);

                SqlParameter Cl_EMAIL = new SqlParameter("@Customer_EMAIL", SqlDbType.NVarChar);
                Cl_EMAIL.Value = txtBoxMail.Text;
                mycommand.Parameters.Add(Cl_EMAIL);

                
                SqlParameter CL_address = new SqlParameter("@Customer_address", SqlDbType.NVarChar);
                CL_address.Value = txtBoxAddress.Text;
                mycommand.Parameters.Add(CL_address);

                SqlParameter Cl_TEL = new SqlParameter("@Customer_Phone", SqlDbType.NVarChar);
                Cl_TEL.Value = txtBoxPhone.Text;
                mycommand.Parameters.Add(Cl_TEL);

                try
                {
                    connection.Open();
                    mycommand.ExecuteNonQuery();
                    MessageBox.Show("Kлиента беше добавен успешно!");
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }
            }
        }
    }
}
