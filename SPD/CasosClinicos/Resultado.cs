using SPD.Apresentação;
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
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void resultado_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = Modelo.Controle.acertos.ToString();
            lblErros.Text = Modelo.Controle.erros.ToString();
            // Calcula as porcentagens
            double porcentagemAcertos = (double)Modelo.Controle.acertos * 100 / Modelo.Controle.totalPerguntas ;
            lblPorAcertos.Text = $"{porcentagemAcertos:N2}%";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Introducao intro = new Introducao();
            intro.Show();
            this.Close();
        }

        private void lblMedia_Click(object sender, EventArgs e)
        {
            
        }

        private void lblErros_Click(object sender, EventArgs e)
        {

        }
    }
}
