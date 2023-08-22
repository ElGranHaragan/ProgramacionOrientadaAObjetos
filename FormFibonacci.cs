using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaAObjetos
{
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int limite = Convert.ToInt32(textBox1.Text);
                if (limite < 0) {
                    MessageBox.Show("Valor negativo no valido");
                }
                int a = 0, b = 1, c = 0;
                richTextBox1.Clear();
                for (; c <= limite;)
                {
                    c = a + b;
                    if(c <= limite)
                    richTextBox1.Text += a+" + " + b + " = " + c + "\n";
                    a = b;
                    b = c;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("El valor no es valido");
            }
        }
    }
}
