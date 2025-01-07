using System.Data;
using System.Data.SqlClient;

namespace shayyan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                {
                    using (SqlCommand cmd = new SqlCommand("loginuser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Email", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            this.Hide();
                            EmployeeForm empForm = new EmployeeForm();
                            empForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool IsValid()
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Email", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;

            }
            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Password", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;

            }

            return true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
