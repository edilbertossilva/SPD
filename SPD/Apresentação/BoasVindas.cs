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
    public partial class BoasVindas : Form
    {
        public BoasVindas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BoasVindas bv = new BoasVindas();
            bv.Show();
            this.Close();
        }

        private void BoasVindas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();           
            //Introducao intro = new Introducao();
            //intro.Show();
            this.Close();
        }
    }
}
