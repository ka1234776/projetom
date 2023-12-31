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
    public partial class frmPesquisarFuncionarios : Form
    {
        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(rdbCodigo.Checked)
            {
                lstPesquisar.Items.Clear();
                lstPesquisar.Items.Add(txtDescricao.Text);

            }

            if(rdbNome.Checked)
            {
                lstPesquisar.Items.Clear();
                lstPesquisar.Items.Add(txtDescricao.Text);
            }
            lstPesquisar.Items.Clear();
            lstPesquisar.Items.Add(txtDescricao.Text);
            txtDescricao.Clear();
            txtDescricao.Focus();
           
        }

        private void limparCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Clear();
            lstPesquisar.Items.Clear();
            txtDescricao.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }
    }
}
