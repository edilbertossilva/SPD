using SPD.Apresentação;
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

namespace SPD.CasosClinicos
{
    public partial class caso1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public caso1()
        {
            InitializeComponent();
        }

        private void caso1_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Arquivos.MaterialApoio materialApoio = new Arquivos.MaterialApoio();
            materialApoio.Show();

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Modelo.Controle.totalPerguntas += 1;
            if (rbtCorreto.Checked == true)
            {
                MessageBox.Show("Certa a resposta"); 
                Modelo.Controle.acertos += 1;//somar variavel global de erros e acertos
                //Modelo.Controle.CalcularPorcentagens();
                caso2 c2 = new caso2();
                c2.ShowDialog();
                this.Close();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta Incorreta");
                Modelo.Controle.erros += 1; //somar variavel global de erros e acertos
                //Modelo.Controle.CalcularPorcentagens();
                caso2 c2 = new caso2();
                c2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha um alternativa");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}