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
    public partial class frmSearchCreditProduct : Form
    {
        public frmSearchCreditProduct()
        {
            InitializeComponent();
        }

        private CreditProduct cp;

        private void frmSearchCreditProduct_Load(object sender, EventArgs e)
        {
            txtCodCrP.Text = cp.Cod;
            txtCrPName.Text = cp.N;
            //comboBox1.Text = cp.Interest;
            //textBox5.Text = cp.DS;
           // textBox6.Text = cp.DS;
            txtSumFrom.Text = cp.DS2;
            txtSumTo.Text = cp.DS2;
        }

        private void button1_Click(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridView dgvCP = new DataGridView();
            dgvCP.Show();
            dgvCP.Dispose();
        }

        

        private void btnExitSearchCrP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchCrP_Click(object sender, EventArgs e)
        {
         
    //        @Cod_p int=null,
    //@Name_p nvarchar(100)=null,
    //@Sum_from numeric(10,2)=null,
    //@Sum_to numeric(10,2)=null,
    //@status char(1)=null
             SqlConnection connection = NewCustomer.CreateConection();

             using (connection)
             {
                 SqlCommand mycommand = new SqlCommand("sp_searchCreditenP", connection);
                 mycommand.CommandType = CommandType.StoredProcedure;
                 mycommand.CommandText = "sp_searchCreditenP";


                 SqlParameter status = new SqlParameter("@status", SqlDbType.Char);

                 switch (this.rbtnAktiv.Checked)
                 {
                     case true: status.Value = 'Y'; break;
                     case false: status.Value = 'N'; break;
                     default: status.Value = null; break;
                 }

                 //i tova raboti!!!

                 //if (this.rbtnAktiv.Checked)
                 //{
                 //    status.Value = 'Y';// Convert.ToChar("1"); 
                 //    // status.Value = ("Y");
                 //}
                 //else
                 //{
                 //    status.Value = 'N';// Convert.ToChar("0");
                 //    //status.Value = 'N';
                 //}
                 //mycommand.Parameters.Add(status);



                 SqlParameter CrP_Name = new SqlParameter("@Name_p", SqlDbType.NVarChar);
                 if (txtCrPName.Text != "")
                 {
                     CrP_Name.Value = txtCrPName.Text;
                 }
                 mycommand.Parameters.Add(CrP_Name);

                 SqlParameter CrP_kod = new SqlParameter("@Cod_p", SqlDbType.Int);
                 if (txtCodCrP.Text != "")
                 {
                     CrP_kod.Value = Convert.ToInt32(txtCodCrP.Text);
                 }
                 mycommand.Parameters.Add(CrP_kod);

                 SqlParameter CrP_SumFrom = new SqlParameter("@Sum_from", SqlDbType.Int);
                 if (txtSumFrom.Text != "")
                 {
                     CrP_SumFrom.Value = Convert.ToInt32(txtSumFrom.Text);
                 }
                 mycommand.Parameters.Add(CrP_SumFrom);

                 SqlParameter CrP_SumTo = new SqlParameter("@Sum_to", SqlDbType.Int);
                 if (txtSumTo.Text != "")
                 {
                     CrP_SumTo.Value = Convert.ToInt32(txtSumTo.Text);
                 }
                 mycommand.Parameters.Add(CrP_SumTo);


                 try
                 {
                     connection.Open();
                     SqlDataReader reader = mycommand.ExecuteReader();
                     if (reader.HasRows)
                     {
                         DataTable dt = new DataTable();
                         dt.Load(reader);
                         dgvCP.DataSource = dt;

                         dt.Columns["PROD_CODE"].ColumnName = "Продукт №";
                         dt.Columns["PROD_NAME"].ColumnName = "Продукт име";
                        dt.Columns["PROD_ACTIVE"].ColumnName = "Статус";
                         dt.Columns["PROD_SUM_FROM"].ColumnName = "Искана сума от";
                         dt.Columns["PROD_SUM_TO"].ColumnName = "Искана сума до";
                         dt.Columns["MODIF_DATE"].ColumnName = "Модифициран на";
                         //dt.Columns["ADRESS_TEXT"].ColumnName = "Адрес";
                         //dt.Columns["CLIENT_NOTE"].ColumnName = "Заележка";
                         //dt.Columns["MODIF_DATE"].ColumnName = "модифицирам на :";


                     }
                     else
                     {
                         MessageBox.Show("Няма намерен кр. продукт!");

                     }
                     reader.Close();
                 }
                 catch (SqlException ol)
                 {

                     MessageBox.Show(ol.Message.ToString());
                 }

             }

        }

        private void dgvCP_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();

            CreditProduct crp = new CreditProduct();

            crp.Cod = Convert.ToString(dgvCP.CurrentRow.Cells[0].Value);
            crp.N = Convert.ToString(dgvCP.CurrentRow.Cells[1].Value);
            crp.Status = Convert.ToChar(dgvCP.CurrentRow.Cells[2].Value);
            crp.Sum_from = Convert.ToString(dgvCP.CurrentRow.Cells[3].Value);
            crp.Sum_to = Convert.ToString(dgvCP.CurrentRow.Cells[4].Value);
            

            //frmCreditProduct frm1 = new frmCreditProduct();
            frmCreditProduct frm1 = new frmCreditProduct(crp);
            frm1.MdiParent = this.MdiParent;
            frm1.Show();

            //  TODO
        }
    }
}
