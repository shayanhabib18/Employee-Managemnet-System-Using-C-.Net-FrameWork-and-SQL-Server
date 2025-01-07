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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace shayyan
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                {
                    using (SqlCommand cmd = new SqlCommand("registeruser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone_no", txtphonenum.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtpass.Text.Trim());
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form1 form = new Form1();
                            form.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }




                    }
                }
            }
        }

        private bool IsValid()
        {
            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Name", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return false;

            }
            if (txtphonenum.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Phone Number", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtphonenum.Focus();
                return false;

            }
            if (txtemail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Email", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
                return false;

            }
            if (txtpass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Password", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Focus();
                return false;

            }
            return true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
