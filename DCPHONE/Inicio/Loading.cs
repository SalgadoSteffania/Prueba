﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCPHONE.Inicio
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int cont = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.Opacity < 1) this.Opacity += 0.5;
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString();
    
            if (ProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void LBLWELCOME_Click(object sender, EventArgs e)
        //{

        //}

        private void Loading_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            ProgressBar1.Value = 0;
            ProgressBar1.Minimum = 0;
            ProgressBar1.Maximum =100;

            timer1.Start();
        }


    }
}
