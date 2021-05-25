﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogin_025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = (from s in db.TB_M_USERs where s.username == txtusername.Text select s).First();
                if (user.password == txtpassword.Text)
                {
                    this.Hide();
                    Form2 a = new Form2();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Password Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}

