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
    public partial class frmSearchContract : Form
    {
        public frmSearchContract()
        {
            InitializeComponent();
        }

        private void btnExitSearchContract_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmSearchContract_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSearchContract_Click(object sender, EventArgs e)
        {
            SqlConnection connection = NewCustomer.CreateConection();
            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_shearchContract", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_shearchContract";



                SqlParameter Cl_name_FirmName = new SqlParameter("@fullname_d", SqlDbType.NVarChar);
                if (txtName_FirmName.Text != "")
                {
                    Cl_name_FirmName.Value = txtName_FirmName.Text;
                }
                mycommand.Parameters.Add(Cl_name_FirmName);

                SqlParameter CL_EGN_BULSTAT = new SqlParameter("@egn_bulstat_d", SqlDbType.NVarChar);
                if (txtEGN_BULSTAT.Text != "")
                {
                    CL_EGN_BULSTAT.Value = txtEGN_BULSTAT.Text;
                }
                mycommand.Parameters.Add(CL_EGN_BULSTAT);


                SqlParameter Srok_d = new SqlParameter("@Srok_d", SqlDbType.Int);
                if (cbSrok.Text != "")
                {
                    Srok_d.Value = Convert.ToInt32(cbSrok.Text);
                }
                mycommand.Parameters.Add(Srok_d);


                SqlParameter contractNo_d = new SqlParameter("@contractNo_d", SqlDbType.NVarChar);
                if (txtcontractNo.Text != "")
                {
                    contractNo_d.Value = txtcontractNo.Text;
                }
                mycommand.Parameters.Add(contractNo_d);

                SqlParameter CreditType_d = new SqlParameter("@CreditType_d", SqlDbType.NVarChar);
                if (cbVidCredit.Text != "")
                {
                    CreditType_d.Value = cbVidCredit.Text;
                }
                else { CreditType_d.Value = null; }
                mycommand.Parameters.Add(CreditType_d);


                try
                {
                    connection.Open();
                    SqlDataReader reader = mycommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgv_SearchContract.DataSource = dt;
                        dt.Columns["CLIENT_ID"].ColumnName = "Клиент номер";
                        dt.Columns["CREDIT_NO"].ColumnName = "кредит номер";
                        dt.Columns["CREDIT_PERIOD"].ColumnName = "Кредитен период";
                        dt.Columns["CLIENT_FULLNAME"].ColumnName = "Име/Фирма";
                        dt.Columns["CLIENT_EGN_BULSTAT"].ColumnName = "ЕГН/БУЛСТАТ";
                        dt.Columns["PROD_NAME"].ColumnName = "кредитен продукт";
 
                    }
                    else
                    {
                        MessageBox.Show("Няма намерен договор!");

                    }
                    reader.Close();
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }
            }
        }

        private void dgv_SearchContract_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();

            Customer CUST = new Customer();
            CreditProduct crP = new CreditProduct();
            Contract contr = new Contract();

            if (CUST.MyType == 1)
            {
                CUST.CompanyName = Convert.ToString(dgv_SearchContract.CurrentRow.Cells[3].Value);
                CUST.BULSTAT = Convert.ToString(dgv_SearchContract.CurrentRow.Cells[4].Value);
                
            }
            else
            {
                CUST.Name = Convert.ToString(dgv_SearchContract.CurrentRow.Cells[3].Value);
                CUST.EGN = Convert.ToString(dgv_SearchContract.CurrentRow.Cells[4].Value);
            }
            //da go dobavq v view-to!!!!!!!!!!!!!

           // CUST.Address = Convert.ToString(dgv_SearchContract.CurrentRow.Cells[...].Value);
            //CUST.E_mail=Convert.ToString(dgv_SearchContract.CurrentRow.Cells[...].Value);
            //CUST.Tel=Convert.ToString(dgv_SearchContract.CurrentRow.Cells[...].Value);

            contr.CrNo=Convert.ToString(dgv_SearchContract.CurrentRow.Cells[1].Value);
            contr.SrocC=Convert.ToString(dgv_SearchContract.CurrentRow.Cells[2].Value);

            //da go dobavq v view-to!!!!!!!!!!!!!

            //contr.DataBeginC=Convert.ToString(dgv_SearchContract.CurrentRow.Cells[...].Value);
            //contr.DataEndC=Convert.ToString(dgv_SearchContract.CurrentRow.Cells[...].Value);
            //contr.WantValueC=Convert.ToString(dgv_SearchContract.CurrentRow.Cells[...].Value);


            crP.N=Convert.ToString(dgv_SearchContract.CurrentRow.Cells[5].Value);



            //TODO................????????

         
            ReviewContract frm= new ReviewContract(CUST,  contr,crP);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void frmSearchContract_Load(object sender, EventArgs e)
        {

        }

       
    }
}
