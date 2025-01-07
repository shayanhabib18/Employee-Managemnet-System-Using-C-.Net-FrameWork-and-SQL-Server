namespace shayyan
{
    partial class Registration
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
            txtname = new TextBox();
            registerbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            txtphonenum = new TextBox();
            label4 = new Label();
            txtemail = new TextBox();
            label5 = new Label();
            txtpass = new TextBox();
            btncancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Sylfaen", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 44);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.FixedSingle;
            txtname.Location = new Point(488, 159);
            txtname.Margin = new Padding(4);
            txtname.Name = "txtname";
            txtname.Size = new Size(227, 31);
            txtname.TabIndex = 1;
            // 
            // registerbtn
            // 
            registerbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            registerbtn.Location = new Point(455, 362);
            registerbtn.Margin = new Padding(4);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(118, 36);
            registerbtn.TabIndex = 2;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(394, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(321, 204);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 0;
            label3.Text = "Phone Number:";
            // 
            // txtphonenum
            // 
            txtphonenum.BorderStyle = BorderStyle.FixedSingle;
            txtphonenum.Location = new Point(488, 198);
            txtphonenum.Margin = new Padding(4);
            txtphonenum.Name = "txtphonenum";
            txtphonenum.Size = new Size(227, 31);
            txtphonenum.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(394, 249);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 0;
            label4.Text = "Email:";
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Location = new Point(488, 243);
            txtemail.Margin = new Padding(4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(227, 31);
            txtemail.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(366, 294);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 0;
            label5.Text = "Password:";
            label5.Click += label5_Click;
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Location = new Point(488, 288);
            txtpass.Margin = new Padding(4);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(227, 31);
            txtpass.TabIndex = 1;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btncancel.Location = new Point(597, 362);
            btncancel.Margin = new Padding(4);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(118, 36);
            btncancel.TabIndex = 2;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1000, 562);
            Controls.Add(btncancel);
            Controls.Add(registerbtn);
            Controls.Add(txtpass);
            Controls.Add(txtemail);
            Controls.Add(txtphonenum);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtname;
        private Button registerbtn;
        private Label label2;
        private Label label3;
        private TextBox txtphonenum;
        private Label label4;
        private TextBox txtemail;
        private Label label5;
        private TextBox txtpass;
        private Button btncancel;
    }
}