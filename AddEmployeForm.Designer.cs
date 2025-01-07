namespace shayyan
{
    partial class AddEmployeForm
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
            label1 = new Label();
            nametxt = new TextBox();
            label2 = new Label();
            phntxt = new TextBox();
            label3 = new Label();
            txtaddress = new TextBox();
            label4 = new Label();
            txtgender = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtedu = new TextBox();
            label7 = new Label();
            txtpost = new TextBox();
            btnadd = new Button();
            label8 = new Label();
            txtdob = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 174);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // nametxt
            // 
            nametxt.BorderStyle = BorderStyle.FixedSingle;
            nametxt.Location = new Point(360, 171);
            nametxt.Margin = new Padding(4);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(155, 31);
            nametxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(526, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 0;
            label2.Text = "Phone Number:";
            label2.Click += label2_Click;
            // 
            // phntxt
            // 
            phntxt.BorderStyle = BorderStyle.FixedSingle;
            phntxt.Location = new Point(694, 167);
            phntxt.Margin = new Padding(4);
            phntxt.Name = "phntxt";
            phntxt.Size = new Size(155, 31);
            phntxt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 259);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 0;
            label3.Text = "Address:";
            // 
            // txtaddress
            // 
            txtaddress.BorderStyle = BorderStyle.FixedSingle;
            txtaddress.Location = new Point(360, 256);
            txtaddress.Margin = new Padding(4);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(155, 31);
            txtaddress.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(600, 250);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 0;
            label4.Text = "Gender:";
            // 
            // txtgender
            // 
            txtgender.BorderStyle = BorderStyle.FixedSingle;
            txtgender.Location = new Point(694, 250);
            txtgender.Margin = new Padding(4);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(155, 31);
            txtgender.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(222, 342);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 0;
            label5.Text = "DateofBirth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(575, 345);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 28);
            label6.TabIndex = 0;
            label6.Text = "Education:";
            // 
            // txtedu
            // 
            txtedu.BorderStyle = BorderStyle.FixedSingle;
            txtedu.Location = new Point(694, 346);
            txtedu.Margin = new Padding(4);
            txtedu.Name = "txtedu";
            txtedu.Size = new Size(155, 31);
            txtedu.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(406, 416);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 0;
            label7.Text = "Position:";
            // 
            // txtpost
            // 
            txtpost.BorderStyle = BorderStyle.FixedSingle;
            txtpost.Location = new Point(506, 414);
            txtpost.Margin = new Padding(4);
            txtpost.Name = "txtpost";
            txtpost.Size = new Size(169, 31);
            txtpost.TabIndex = 1;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(254, 478);
            btnadd.Margin = new Padding(4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(530, 36);
            btnadd.TabIndex = 2;
            btnadd.Text = "Add ";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Sylfaen", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(418, 63);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(268, 38);
            label8.TabIndex = 0;
            label8.Text = "Add Employee Data";
            // 
            // txtdob
            // 
            txtdob.Format = DateTimePickerFormat.Short;
            txtdob.Location = new Point(360, 346);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(155, 31);
            txtdob.TabIndex = 3;
            // 
            // AddEmployeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1000, 562);
            Controls.Add(txtdob);
            Controls.Add(btnadd);
            Controls.Add(txtedu);
            Controls.Add(txtgender);
            Controls.Add(phntxt);
            Controls.Add(txtpost);
            Controls.Add(txtaddress);
            Controls.Add(nametxt);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "AddEmployeForm";
            Text = "AddEmployeForm";
            Load += AddEmployeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nametxt;
        private Label label2;
        private TextBox phntxt;
        private Label label3;
        private TextBox txtaddress;
        private Label label4;
        private TextBox txtgender;
        private Label label5;
        private Label label6;
        private TextBox txtedu;
        private Label label7;
        private TextBox txtpost;
        private Button btnadd;
        private Label label8;
        private DateTimePicker txtdob;
    }
}