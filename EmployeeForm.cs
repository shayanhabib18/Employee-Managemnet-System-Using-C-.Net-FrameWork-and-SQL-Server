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

namespace shayyan
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void addemp_Click(object sender, EventArgs e)
        {
            AddEmployeForm.update = false;
            AddEmployeForm empfm = new AddEmployeForm();
            empfm.ShowDialog();
            dgvEmployee.DataSource = empfm.getTable();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadValuesInDataGridView();
        }

        private void LoadValuesInDataGridView()
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
            dgvEmployee.DataSource = dt;
        }

        private void edtemp_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvEmployee.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvEmployee.Rows[selectedRowIndex];

            // Get the EmployeeID value from the selected row
            int selectedID = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
            AddEmployeForm.EmployeeID = selectedID;
            AddEmployeForm.update = true;
            AddEmployeForm aef = new AddEmployeForm();
            aef.ShowDialog();
            AddEmployeForm.update = false;
            dgvEmployee.DataSource = aef.getTable();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delemp_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvEmployee.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvEmployee.Rows[selectedRowIndex];

            // Get the EmployeeID value from the selected row
            int selectedID = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);
            DeleteEmployee(selectedID);
        }

        private void DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
            {
                using (SqlCommand cmd = new SqlCommand("stp_Employee", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@isUpdate", 3);
                        cmd.Parameters.AddWithValue("@EmployeeID", id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddEmployeForm aef = new AddEmployeForm();
                        dgvEmployee.DataSource = aef.getTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
