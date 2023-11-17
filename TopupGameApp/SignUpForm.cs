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
    public partial class SignupForm : Form
    {
        public bool isSignUp = false;
        public SignupForm(bool isSignUp)
        {
            this.isSignUp = isSignUp;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đóng form không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (isSignUp == true)
            {
                SignUp();
            }
            else
            {
                string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                               .ToString();

                string strCommand = "dbLogin";

                SqlConnection myConnection = new SqlConnection(strConnectString);
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@Username", txtName.Text);
                myCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
                myCommand.Parameters.Add(new SqlParameter("@Check", SqlDbType.VarChar, 10));
                myCommand.Parameters["@Check"].Direction = ParameterDirection.Output;
                myCommand.ExecuteNonQuery();
                MessageBox.Show(myCommand.Parameters["@Check"].Value.ToString());
                myConnection.Close();
                MessageBox.Show("Dang ki tai khoan thanh cong");
                this.Close();
            }
        }

        private void SignUp()
        {
            string strConnectString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"]
                               .ToString();

            string strCommand = "Insert into IUSER (USERNAME,IPASSWORD, IEMAIL) values (" +
                " '" + txtName.Text + "'," +
                " '" + txtPassword.Text + "'," +
                " '" + txtEmail.Text + "')";

            SqlConnection myConnection = new SqlConnection(strConnectString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            this.Close();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            if (isSignUp == false)
            {
                SignUplb.Text = "LOG IN";
                Emaillb.Visible = false;
                txtEmail.Visible = false;
                btnSignup.Text = "Log In";
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emaillb_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
