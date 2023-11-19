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

namespace TopupGameApp
{
    public partial class MainWeb : Form
    {
        public MainWeb()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm(false);
            signupForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                    .ToString();

                string strSearch = "'%" + this.SearchBox.Text + "%'";
                string strCommand = "Select * from PRODUCT where ProdName like " + strSearch;
                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();


                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                DataSet ds = new DataSet();
                da.Fill(ds, "Product");

                this.dgvProduct.DataSource = ds;
                this.dgvProduct.DataMember = "Product";

                myConnection.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WebName_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm(true);
            signupForm.ShowDialog();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainWeb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet1.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter1.Fill(this.storeDBDataSet1.PRODUCT);
            

        }

    }
}
