using ProgramPediabetico.Apresentacao;
using SPD.Apresentação;
using SPD.Modelo;
using System;
using System.Windows.Forms;

namespace SPD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso! ", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Introducao intro = new Introducao();
                    intro.Show();
                    //this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }         
    

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(); 
            cad.Show();
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
