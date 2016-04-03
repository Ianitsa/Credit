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
    public  partial class frmCreditProduct : Form
    {
        public frmCreditProduct()
        {
            InitializeComponent();
        }
        CreditProduct cr;
        public frmCreditProduct(CreditProduct cred)
        {
            InitializeComponent();
            this.cr = cred;
        }

        double interestP;
        public double Interest
        {
            get { return interestP;}
            set {interestP=value ;} 
        }

        private void frmCreditProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ianiDataSet2.PROD_PERIODS' table. You can move, or remove it, as needed.
            this.pROD_PERIODSTableAdapter.Fill(this.ianiDataSet2.PROD_PERIODS);
            // TODO: This line of code loads data into the 'ianiDataSet2.CREDIT_PRODUCT' table. You can move, or remove it, as needed.
            this.cREDIT_PRODUCTTableAdapter2.Fill(this.ianiDataSet2.CREDIT_PRODUCT);
            // TODO: This line of code loads data into the 'ianiDataSet1.CREDIT_PRODUCT' table. You can move, or remove it, as needed.
            this.cREDIT_PRODUCTTableAdapter1.Fill(this.ianiDataSet1.CREDIT_PRODUCT);
            // TODO: This line of code loads data into the 'ianiDataSet1.INTEREST' table. You can move, or remove it, as needed.
            this.iNTERESTTableAdapter.Fill(this.ianiDataSet1.INTEREST);
            // TODO: This line of code loads data into the 'ianiDataSet.CREDIT_PRODUCT' table. You can move, or remove it, as needed.
            this.cREDIT_PRODUCTTableAdapter.Fill(this.ianiDataSet.CREDIT_PRODUCT);
            CreditProduct creditproduct = new CreditProduct();

           // txtClientID.Text = c.Cust_Id;

            txtbN.Text = cr.N;
            txtbCod.Text = cr.Cod;
            txtSumFrom.Text = cr.Sum_from;
            txtSumTo.Text = cr.Sum_to;


            //????
            if (cr.Status=='Y')
            {
                rbtnActiv.Checked = true;
            }
            else
            {
                rbtnNoActiv.Checked = true;   
            }
            
            

            //creditproduct.Cod = txtbCod.Text;
            //creditproduct.N = txtbN.Text;
            txtbCod.ReadOnly = true;
            txtbN.ReadOnly = true;
            cbInterest.Enabled = false;
            cbLimit.Enabled = false;
            txtSumFrom.ReadOnly = true;
            txtSumTo.ReadOnly = true;
            rbtnActiv.Enabled = false;
            rbtnNoActiv.Enabled = false;

            btnSaveCrP.Enabled = false;
             

            creditproduct.Interest = this.cbInterest.Text;
            //creditproduct.DS = this.txtSrokFrom.Text;
            //creditproduct.DS = this.txtSrokTo.Text;
            creditproduct.DS2 = this.txtSumFrom.Text;
            creditproduct.DS2 = this.txtSumTo.Text;
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            //ResetFormFields();
            txtbN.ReadOnly = false;
            cbInterest.Enabled = true;
            cbLimit.Enabled = true;
            txtSumFrom.ReadOnly = false;
            txtSumTo.ReadOnly = false;
            rbtnActiv.Enabled = true;
            rbtnNoActiv.Enabled = true;

            btnSaveCrP.Enabled = true;

        }

        protected virtual void ResetFormFields()
        {
            this.txtbCod.Clear();
            this.txtbN.Clear();
            this.cbInterest.SelectedIndex = -1;
            //this.txtSrokFrom.Clear();
            //this.txtSrokTo.Clear();
            this.txtSumFrom.Clear();
            this.txtSumTo.Clear();
            
        }

        private void btnExitCrP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSaveCrP_Click(object sender, EventArgs e)
        {
            SqlConnection connection = NewCustomer.CreateConection();
            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_updateCrProduct", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_updateCrProduct";


                SqlParameter CrP_kod = new SqlParameter("@P_cod", SqlDbType.Int);
                if (txtbCod.Text != "")
                {
                    CrP_kod.Value = Convert.ToInt32(txtbCod.Text);
                }
                mycommand.Parameters.Add(CrP_kod);

                SqlParameter CrPName = new SqlParameter("@P_name", SqlDbType.NVarChar);
                CrPName.Value = txtbN.Text;
                mycommand.Parameters.Add(CrPName);

                SqlParameter active = new SqlParameter("@P_active", SqlDbType.Char);
                //activ.Value = txtbN.Text;
                if (this.rbtnActiv.Checked)
                {
                    active.Value = 'Y';
                }
                else
                {
                    active.Value = 'N';
                }
                mycommand.Parameters.Add(active);


                SqlParameter CrP_SumFrom = new SqlParameter("@P_sumFrom", SqlDbType.Decimal);
                if (txtSumFrom.Text != "")
                {
                    CrP_SumFrom.Value = Convert.ToDecimal(txtSumFrom.Text);
                }
                mycommand.Parameters.Add(CrP_SumFrom);

                SqlParameter CrP_SumTo = new SqlParameter("@P_sumTo", SqlDbType.Decimal);
                if (txtSumTo.Text != "")
                {
                    CrP_SumTo.Value = Convert.ToDecimal(txtSumTo.Text);
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

                    MessageBox.Show("Продукта беше променен успешно!");
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }
            }

            SqlConnection conn = NewCustomer.CreateConection();
            using (conn)
            {
                SqlCommand mycommand1 = new SqlCommand("sp_updateInterest", conn);
                mycommand1.CommandType = CommandType.StoredProcedure;
                mycommand1.CommandText = "sp_updateInterest";

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

                    MessageBox.Show("Лихвата беше променена успешно!");
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }

            }
        }

        

        

        
        
    }
}
