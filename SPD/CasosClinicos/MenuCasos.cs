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
    public partial class MenuCasos : Form
    {
        public MenuCasos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.Controle.totalPerguntas = 0;
            Modelo.Controle.acertos = 0;
            Modelo.Controle.erros = 0;
            CasosClinicos.caso1 c1 = new CasosClinicos.caso1();
            c1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelo.Controle.totalPerguntas = 0;
            Modelo.Controle.acertos = 0;
            Modelo.Controle.erros = 0;
            CasosClinicos.caso1 c1 = new CasosClinicos.caso1();
            c1.ShowDialog();
            this.Close();
        }

        private void MenuCasos_Load(object sender, EventArgs e)
        {

        }
    }
}
