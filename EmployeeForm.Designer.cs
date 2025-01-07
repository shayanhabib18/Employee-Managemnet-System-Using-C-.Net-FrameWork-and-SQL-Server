namespace shayyan
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployee = new DataGridView();
            label1 = new Label();
            addemp = new Button();
            edtemp = new Button();
            delemp = new Button();
            btnclose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.BackgroundColor = SystemColors.ButtonFace;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(244, 71);
            dgvEmployee.Margin = new Padding(4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(714, 442);
            dgvEmployee.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Sylfaen", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 38);
            label1.TabIndex = 1;
            label1.Text = "Employee Details";
            // 
            // addemp
            // 
            addemp.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addemp.Location = new Point(44, 131);
            addemp.Margin = new Padding(4);
            addemp.Name = "addemp";
            addemp.Size = new Size(168, 36);
            addemp.TabIndex = 2;
            addemp.Text = "Add Employee";
            addemp.UseVisualStyleBackColor = true;
            addemp.Click += addemp_Click;
            // 
            // edtemp
            // 
            edtemp.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            edtemp.Location = new Point(44, 191);
            edtemp.Margin = new Padding(4);
            edtemp.Name = "edtemp";
            edtemp.Size = new Size(168, 36);
            edtemp.TabIndex = 2;
            edtemp.Text = "Edit Employee";
            edtemp.UseVisualStyleBackColor = true;
            edtemp.Click += edtemp_Click;
            // 
            // delemp
            // 
            delemp.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            delemp.Location = new Point(44, 253);
            delemp.Margin = new Padding(4);
            delemp.Name = "delemp";
            delemp.Size = new Size(168, 36);
            delemp.TabIndex = 2;
            delemp.Text = "Delete Employee";
            delemp.UseVisualStyleBackColor = true;
            delemp.Click += delemp_Click;
            // 
            // btnclose
            // 
            btnclose.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(44, 321);
            btnclose.Margin = new Padding(4);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(168, 36);
            btnclose.TabIndex = 2;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnclose);
            Controls.Add(delemp);
            Controls.Add(edtemp);
            Controls.Add(addemp);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Margin = new Padding(4);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            WindowState = FormWindowState.Maximized;
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private Label label1;
        private Button addemp;
        private Button edtemp;
        private Button delemp;
        private Button btnclose;
    }
}