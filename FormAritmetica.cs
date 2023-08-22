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
    public partial class FormAritmetica : Form
    {
        public FormAritmetica()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAritmetica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                float dato1 = float.Parse(textBox1.Text);
                float dato2 = float.Parse(textBox2.Text);

                float suma = dato1 + dato2;
                float resta = dato1 - dato2;
                float multiplicacion = dato1 * dato2;
                float division = dato1 / dato2;

                label4.Text = dato1 + "+" + dato2 + "=" + suma + "\n";
                label4.Text += dato1 + "-" + dato2 + "=" + resta + "\n";
                label4.Text += dato1 + "*" + dato2 + "=" + multiplicacion + "\n";
                label4.Text += dato1 + "/" + dato2 + "=" + division + "\n";

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error", "Errorsito", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
