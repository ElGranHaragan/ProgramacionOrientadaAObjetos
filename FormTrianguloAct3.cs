
using System;
using System.Windows.Forms;


namespace ProgramacionOrientadaAObjetos
{
    public partial class FormTrianguloAct3 : Form
    {
        public FormTrianguloAct3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                float lado1 = float.Parse(textBox1.Text);
                float lado2 = float.Parse(textBox2.Text);
                float lado3 = float.Parse(textBox3.Text);

                if (lado1 > 0 && lado2 > 0 && lado3 > 0)
                {
                    float mayor = lado1;

                    if (mayor < lado2) mayor = lado2;


                    if (mayor < lado3) mayor = lado3;


                    if (mayor <= (lado1 + lado2 + lado3 - mayor))
                    {

                        if (lado1 == lado2 && lado1 == lado3)
                        {
                            label5.Text = "Es un triángulo equilátero";
                        }

                        else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
                        {
                            label5.Text = "Es un triángulo escaleno";
                        }
                        else
                        {
                            label5.Text = "Es un triángulo isosceles";
                        }
                    }
                    else
                    {
                        label5.Text = "Con estas medidas NO es posible formar un triágunlo";
                    }

                }
                else
                {
                    label5.Text = "Con estas medidas NO es posible formar un triágunlo";
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error", "Errorsito", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }

        }

        private void Form_Triangulo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormTrianguloAct3_Load(object sender, EventArgs e)
        {

        }
    }
}
