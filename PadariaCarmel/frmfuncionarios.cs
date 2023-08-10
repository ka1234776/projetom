using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PadariaCarmel
{
    public partial class frmFuncionarios : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            desabilitarCampos();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pnlFuncionarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }



        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;


            mskCep.Enabled = false;
            mskCpf.Enabled = false;
            mskTel.Enabled = false;

            cbbEstado.Enabled = false;


            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

           // desabilitarCampos();



        }

        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;


            mskCep.Enabled = true;
            mskCpf.Enabled = true;
            mskTel.Enabled = true;

            cbbEstado.Enabled = true;


            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            txtNome.Focus();




        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso!!!",
                "Menssagem do sistema.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            desabilitarCampos();
            btnNovo.Enabled = true;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtEmail.Clear();


            mskCep.Clear();
            mskCpf.Clear();
            mskTel.Clear();

            cbbEstado.Text = "";



            txtNome.Focus();




        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            {
                frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
                abrir.ShowDialog();
            }
            desabilitarCampos();
        }
        

        public void buscaCEP(string numCEP)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            try
            { 
            WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);

            txtEndereco.Text  = endereco.end;
            txtBairro.Text = endereco.bairro;
            txtCidade.Text = endereco.cidade;
            cbbEstado.Text = endereco.uf;
            }
            catch(Exception)
            {
                MessageBox.Show("Favor inserir CEP valido!!!", "menssagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                mskCep.Focus();
                mskCep.Text = "";
            }


        }

        private void btnCarregaCEP_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mskCep.Text);
                txtNumero.Focus();

            }
        }
    }
}