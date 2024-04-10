using SPD.CasosClinicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPD.Apresentação
{
    public partial class Introducao : Form
    {
        public Introducao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CasosClinicos.MenuCasos cs = new CasosClinicos.MenuCasos();
            cs.Show();
            this.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CasosClinicos.Resultado resultado = new CasosClinicos.Resultado();
            resultado.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arquivos.MaterialApoio materialApoio = new Arquivos.MaterialApoio();
            materialApoio.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Apresentação.BoasVindas boasVindas = new BoasVindas();
            boasVindas.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Close();
        }
    }
}
