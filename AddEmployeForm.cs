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
    public partial class AddEmployeForm : Form
    {
        public static bool update = false;
        public static int EmployeeID;
        public AddEmployeForm()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (!update)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                    {
                        using (SqlCommand cmd = new SqlCommand("stp_Employee", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@isUpdate", 0);
                            cmd.Parameters.AddWithValue("@Name", nametxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone_No", phntxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@DateOfBirth", txtdob.Value);
                            cmd.Parameters.AddWithValue("@Gender", txtgender.Text.Trim());
                            cmd.Parameters.AddWithValue("@Education", txtedu.Text.Trim());
                            cmd.Parameters.AddWithValue("@Position", txtpost.Text.Trim());

                            con.Open();
                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                update = false;
                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }

                    }
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                    {
                        using (SqlCommand cmd = new SqlCommand("stp_Employee", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@isUpdate", 1);
                            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                            cmd.Parameters.AddWithValue("@Name", nametxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone_No", phntxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@DateOfBirth", txtdob.Value);
                            cmd.Parameters.AddWithValue("@Gender", txtgender.Text.Trim());
                            cmd.Parameters.AddWithValue("@Education", txtedu.Text.Trim());
                            cmd.Parameters.AddWithValue("@Position", txtpost.Text.Trim());

                            con.Open();
                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                update = false;
                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
            }
        }

        private bool IsValid()
        {
            if (nametxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Name", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nametxt.Focus();
                return false;

            }
            if (phntxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Phone Number", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phntxt.Focus();
                return false;

            }
            if (txtaddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Address", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaddress.Focus();
                return false;

            }
            if (txtdob.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your DateOfBirth", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdob.Focus();
                return false;

            }
            if (txtedu.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Education", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtedu.Focus();
                return false;

            }
            if (txtpost.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Your Position", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpost.Focus();
                return false;

            }

            return true;
        }

        private void AddEmployeForm_Load(object sender, EventArgs e)
        {
            if (update)
            {
                MapValues();
            }
            else
            {
                SetRefresh();
            }
        }

        private void SetRefresh()
        {
            nametxt.Text = "";
            phntxt.Text = "";
            txtaddress.Text = "";
            txtgender.Text = "";
            txtdob.Text = "";
            txtedu.Text = "";
            txtpost.Text = "";
        }

        private void MapValues()
        {
                btnadd.Text = "Update";
                DataTable dt = getTable();
                nametxt.Text = dt.Rows[0]["Name"].ToString();
                phntxt.Text = dt.Rows[0]["Phone_no"].ToString();
                txtaddress.Text = dt.Rows[0]["Address"].ToString();
                txtgender.Text = dt.Rows[0]["Gender"].ToString();
                txtdob.Value = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"].ToString());
                txtedu.Text = dt.Rows[0]["Education"].ToString();
                txtpost.Text = dt.Rows[0]["Position"].ToString();
        }

        public DataTable getTable()
        {
            if (!update)
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                {
                    using (SqlCommand cmd = new SqlCommand("stp_Employee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@isUpdate", 2);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                    }
                }
                return dt;
            }
            else
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                {
                    using (SqlCommand cmd = new SqlCommand("stp_Employee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@isUpdate", 4);
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                    }
                }
                return dt;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
