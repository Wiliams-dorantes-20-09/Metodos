﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "TEC" && textBox2.Text == "1234")
            {
                MessageBox.Show("usuario Valido");
                Menu m = new Menu();
                m.Visible = true;
                this.Visible = false;
            }
            else 
            {
                MessageBox.Show("Usuario invalido");
            }
           
        }
    }
}
