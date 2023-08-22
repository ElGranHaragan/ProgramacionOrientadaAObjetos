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
    public partial class FormFormulaGeneral : Form
    {
        public FormFormulaGeneral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                double x1 = (-b+Math.Sqrt((b*b) -(4*a*c)))/(2*a);
                double x2 = (-b-Math.Sqrt((b*b) -(4*a*c)))/(2*a);
                label4.Text = "x1 = " + x1;
                label5.Text = "x2 = " + x2;
            }
            catch (Exception ex)
            { MessageBox.Show("Alguno de los datos no es valido");

            }
        }
    }
}
