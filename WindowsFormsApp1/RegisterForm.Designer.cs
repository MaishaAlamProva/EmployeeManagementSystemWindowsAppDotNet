namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.signIn_loginbtn = new System.Windows.Forms.Button();
            this.login_showpass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signin_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signin_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // signIn_loginbtn
            // 
            this.signIn_loginbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signIn_loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signIn_loginbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_loginbtn.Location = new System.Drawing.Point(496, 461);
            this.signIn_loginbtn.Name = "signIn_loginbtn";
            this.signIn_loginbtn.Size = new System.Drawing.Size(266, 85);
            this.signIn_loginbtn.TabIndex = 19;
            this.signIn_loginbtn.Text = "Sign In";
            this.signIn_loginbtn.UseVisualStyleBackColor = false;
            // 
            // login_showpass
            // 
            this.login_showpass.AutoSize = true;
            this.login_showpass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showpass.Location = new System.Drawing.Point(720, 381);
            this.login_showpass.Name = "login_showpass";
            this.login_showpass.Size = new System.Drawing.Size(130, 22);
            this.login_showpass.TabIndex = 18;
            this.login_showpass.Text = "Show Password";
            this.login_showpass.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Register Account";
            // 
            // signin_pass
            // 
            this.signin_pass.Location = new System.Drawing.Point(413, 327);
            this.signin_pass.Multiline = true;
            this.signin_pass.Name = "signin_pass";
            this.signin_pass.Size = new System.Drawing.Size(420, 37);
            this.signin_pass.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // signin_username
            // 
            this.signin_username.Location = new System.Drawing.Point(413, 220);
            this.signin_username.Multiline = true;
            this.signin_username.Name = "signin_username";
            this.signin_username.Size = new System.Drawing.Size(420, 39);
            this.signin_username.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(15, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 703);
            this.panel1.TabIndex = 11;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 700);
            this.Controls.Add(this.signIn_loginbtn);
            this.Controls.Add(this.login_showpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signin_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signin_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signIn_loginbtn;
        private System.Windows.Forms.CheckBox login_showpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox signin_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signin_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}