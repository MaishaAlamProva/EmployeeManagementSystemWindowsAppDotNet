﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

         private void signIn_loginbtn_Click(object sender, EventArgs e)
         {
            MainForm loginForm = new MainForm();
             loginForm.ShowDialog();
             this.Hide();
         }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
