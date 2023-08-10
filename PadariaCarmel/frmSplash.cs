﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCarmel
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }


        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if(pgbCarregando.Value <100)
            {
                pgbCarregando.Value = pgbCarregando.Value + 10;
                lblCarregando.Text = pgbCarregando.Value.ToString();
            }
            else
            {
                tmrSplash.Enabled = false;
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
            }

        }
    }
}
