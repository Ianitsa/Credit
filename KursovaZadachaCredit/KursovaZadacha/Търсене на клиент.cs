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
    public partial class frmSearchClient : Form
    {
        public frmSearchClient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //!!!!!!!!!!!!!!
            this.Close();

        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            NewCustomer frm1 = new NewCustomer();
            //!!!!!!!!
            frm1.MdiParent = this.MdiParent;
            frm1.Show();
        }

        private void frmSearchClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            SqlConnection connection = NewCustomer.CreateConection();
            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_SearchCustomer", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_SearchCustomer";

                SqlParameter ClientID = new SqlParameter("@client_id", SqlDbType.Int);
                if (txt_ID_SCustomer.Text != "")
                {
                  ClientID.Value =Convert.ToInt32(txt_ID_SCustomer.Text);
                }
                              
                
               mycommand.Parameters.Add(ClientID);


                //SqlParameter Fullname_nameCompany = new SqlParameter("@CLIENT_FULLNAME", SqlDbType.NVarChar);
                //Fullname.Value = txtSurchLNameC.Text;
                //mycommand.Parameters.Add(Fullname);

                //SqlParameter FullnameCompany = new SqlParameter("@CLIENT_FULLNAME", SqlDbType.NVarChar);
                //FullnameCompany.Value = txtBoxFirmName.Text;
                //mycommand.Parameters.Add(FullnameCompany);

                //***???

                SqlParameter FL_JL = new SqlParameter("@Client_type", SqlDbType.Char);

                if (this.rbtnJL_C.Checked) { FL_JL.Value =Convert.ToChar( "0"); }
                else { FL_JL.Value =Convert.ToChar ( "1"); }
                mycommand.Parameters.Add(FL_JL);

                //SqlParameter FL = new SqlParameter("@CLIENT_TYPE", SqlDbType.Char);
                //SqlParameter CL_EGN = new SqlParameter("@CLIENT_EGN_BULSTAT", SqlDbType.NVarChar);
                //SqlParameter Fullname_nameCompany = new SqlParameter("@CLIENT_FULLNAME", SqlDbType.NVarChar);
                              
                //if (this.rbtnJL_C.Checked) 
                //{ 
                //    FL.Value = Convert.ToChar("J");
                //    CL_EGN.Value = txtBoxBulstat.Text;
                //    Fullname_nameCompany.Value = txtBoxFirmName.Text;
                //}
                //else 
                //{  
                //    FL.Value  = Convert.ToChar("F");
                //    CL_EGN.Value = txtBoxEGN.Text;
                //    Fullname_nameCompany.Value = txtSurchLNameC.Text;
                //}                
                //mycommand.Parameters.Add(FL);
                //mycommand.Parameters.Add(CL_EGN);
                //mycommand.Parameters.Add(Fullname_nameCompany);

                SqlParameter Cl_name_FirmName = new SqlParameter("@Customer_fullname", SqlDbType.NVarChar);
                if (txtFullName.Text != "")
                {
                    Cl_name_FirmName.Value = txtFullName.Text;
                }
                mycommand.Parameters.Add(Cl_name_FirmName);

                SqlParameter CL_EGN_BULSTAT = new SqlParameter("@Customer_EGN_BULSTAT", SqlDbType.NVarChar);
                if (txtBoxEGN.Text != "")
                {
                    CL_EGN_BULSTAT.Value = txtBoxEGN.Text;
                }
                mycommand.Parameters.Add(CL_EGN_BULSTAT);



                SqlParameter Cl_EMAIL = new SqlParameter("@Customer_EMAIL", SqlDbType.NVarChar);
                if (txtBoxMail.Text != "")
                {
                    Cl_EMAIL.Value = txtBoxMail.Text;
                }
                mycommand.Parameters.Add(Cl_EMAIL);
                
                SqlParameter Cl_TEL = new SqlParameter("@Customer_Phone", SqlDbType.NVarChar);
                if (txtBoxPhone.Text != "")
                {
                    Cl_TEL.Value = txtBoxPhone.Text;
                }
                mycommand.Parameters.Add(Cl_TEL);

                try
                {
                    connection.Open();
                    SqlDataReader reader = mycommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgv_SearchClient.DataSource = dt;

                        dt.Columns["CLIENT_ID"].ColumnName = "Клиент номер";
                        dt.Columns["CLIENT_TYPE"].ColumnName = "Тип клиент";
                        dt.Columns["CLIENT_EGN_BULSTAT"].ColumnName = "ЕГН/БУЛСТАТ"; 
                        dt.Columns["CLIENT_FULLNAME"].ColumnName = "Име/Фирма";
                        dt.Columns["EMAIL"].ColumnName = "Емайл";
                        dt.Columns["TELEPHONE"].ColumnName = "Телефон";
                        dt.Columns["ADRESS_TEXT"].ColumnName = "Адрес";
                        dt.Columns["CLIENT_NOTE"].ColumnName = "Заележка";
                        dt.Columns["MODIF_DATE"].ColumnName = "модифициран на :";

                       
                        
                    }
                    else
                    {
                        MessageBox.Show("Няма намерен клиент!");
                     
                    }
                    reader.Close();
                }
                catch(SqlException ol)
                {
                    
                    MessageBox.Show(ol.Message.ToString());
                }

            }
        }

       

       

        private void dgv_SearchClient_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();
           

            Customer CUST = new Customer();

            CUST.Cust_Id = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[0].Value);
            CUST.MyType = Convert.ToChar(dgv_SearchClient.CurrentRow.Cells[1].Value);

            if (CUST.MyType==1)
            {
                //CUST.Name = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[3].Value);
                //CUST.EGN = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[2].Value);
                CUST.CompanyName = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[3].Value);
                CUST.BULSTAT = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[2].Value);
            }
            else
            {
                CUST.Name = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[3].Value);
                CUST.EGN = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[2].Value);
                //CUST.CompanyName = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[3].Value);
                //CUST.BULSTAT = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[2].Value);
            }
            
            CUST.E_mail = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[4].Value);
            CUST.Address = Convert.ToString(dgv_SearchClient.CurrentRow.Cells[6].Value);
            CUST.Tel =  Convert.ToString(dgv_SearchClient.CurrentRow.Cells[5].Value);
            



            //.....TODO
            ReCustomer frm = new ReCustomer(CUST);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frmSearchClient_Load(object sender, EventArgs e)
        {

        }

      

       
    }
}
