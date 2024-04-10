using SPD;
using SPD.CasosClinicos;
using SPD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramPediabetico.Apresentacao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txbEmail.Text, txbNome.Text, txbNascimento.Text, txbSexo.Text, txbSenha.Text, txbConfsenha.Text);
            if (controle.tem)// mensagem de sucesso
            {
                MessageBox.Show(mensagem,"Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form = new Form1();  
                form.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
