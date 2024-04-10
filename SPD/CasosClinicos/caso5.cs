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
    public partial class caso5 : Form
    {
        public caso5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.Controle.totalPerguntas += 1;
            if (rbtCorreto.Checked == true)
            {
                MessageBox.Show("Certa a resposta");
                Modelo.Controle.acertos += 1;//somar variavel global de erros e acertos
                caso6 c6 = new caso6();
                c6.ShowDialog();
                this.Close();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta Icorreta");
                Modelo.Controle.erros += 1;//somar variavel global de erros e acertos                this.Dispose();caso1 c1 = new caso1();
                caso6 c6 = new caso6();
                c6.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha um alternativa");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arquivos.MaterialApoio materialApoio = new Arquivos.MaterialApoio();
            materialApoio.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
