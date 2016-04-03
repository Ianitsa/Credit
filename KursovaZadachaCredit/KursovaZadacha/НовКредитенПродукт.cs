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
    public partial class NewCrProd : Form
    {
        public NewCrProd()
        {
            InitializeComponent();
        }

        private void btnSaveCrP_Click(object sender, EventArgs e)
        {
             SqlConnection connection = NewCustomer.CreateConection();
             using (connection)
             {
                 SqlCommand mycommand = new SqlCommand("sp_insertCrProduct", connection);
                 mycommand.CommandType = CommandType.StoredProcedure;
                 mycommand.CommandText = "sp_insertCrProduct";



                 SqlParameter CrPName = new SqlParameter("@P_name", SqlDbType.NVarChar);
                 CrPName.Value = txtbN.Text;
                 mycommand.Parameters.Add(CrPName);

                 SqlParameter active = new SqlParameter("@P_active", SqlDbType.Char);
                 //activ.Value = txtbN.Text;
                 if (this.rbtnActiv.Checked)
                 {
                     active.Value='Y';
                 }
                 else
                 {
                     active.Value = 'N';   
                 }
                 mycommand.Parameters.Add(active);

                 
                 SqlParameter CrP_SumFrom = new SqlParameter("@P_sumFrom", SqlDbType.Int);
                 if (txtSumFrom.Text != "")
                 {
                     CrP_SumFrom.Value = Convert.ToInt32(txtSumFrom.Text);
                 }
                 mycommand.Parameters.Add(CrP_SumFrom);

                 SqlParameter CrP_SumTo = new SqlParameter("@P_sumTo", SqlDbType.Int);
                 if (txtSumTo.Text != "")
                 {
                     CrP_SumTo.Value = Convert.ToInt32(txtSumTo.Text);
                 }
                 mycommand.Parameters.Add(CrP_SumTo);

                 SqlParameter Cr_interest = new SqlParameter("@interest", SqlDbType.Decimal);
                 if (txtSumTo.Text != "")
                 {
                     Cr_interest.Value = Convert.ToDecimal(cbInterest.Text);
                 }
                 
                 mycommand.Parameters.Add(Cr_interest);

                 try
                 {
                     connection.Open();
                     mycommand.ExecuteNonQuery();

                     MessageBox.Show("Продукта беше добавен успешно!");
                 }
                 catch (SqlException ol)
                 {

                     MessageBox.Show(ol.Message.ToString());
                 }
             }

            SqlConnection conn = NewCustomer.CreateConection();
            using (conn)
            {
                SqlCommand mycommand1 = new SqlCommand("sp_insertInterest", conn);
                mycommand1.CommandType = CommandType.StoredProcedure;
                mycommand1.CommandText = "sp_insertInterest";

//   @P_cod int,
//@P_period
                SqlParameter CrP_kod = new SqlParameter("@P_cod", SqlDbType.Int);
                if (txtbCod.Text != "")
                {
                    CrP_kod.Value = Convert.ToInt32(txtbCod.Text);
                }
                mycommand1.Parameters.Add(CrP_kod);

                SqlParameter Cr_srock = new SqlParameter("@P_period", SqlDbType.Int);
                Cr_srock.Value = Convert.ToInt32(cbLimit.Text);
                mycommand1.Parameters.Add(Cr_srock);


                try
                {
                    conn.Open();
                    mycommand1.ExecuteNonQuery();

                    MessageBox.Show("Лихвата беше добавена успешно!");
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }

            }
        }

        private void NewCrProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ianiDataSet2.PROD_PERIODS' table. You can move, or remove it, as needed.
            this.pROD_PERIODSTableAdapter.Fill(this.ianiDataSet2.PROD_PERIODS);
            // TODO: This line of code loads data into the 'ianiDataSet2.CREDIT_PRODUCT' table. You can move, or remove it, as needed.
            this.cREDIT_PRODUCTTableAdapter.Fill(this.ianiDataSet2.CREDIT_PRODUCT);

        }


    }
}
