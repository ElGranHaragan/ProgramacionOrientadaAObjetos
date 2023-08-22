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
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
        {
            InitializeComponent();
        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text !="" && textBox3.Text !="" && textBox4.Text !="")
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, "$" + textBox3.Text, textBox4.Text);
            }
            else
            {
                MessageBox.Show("Te faltan datos", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que el carácter ingresado sea mostrado en el TextBox
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que el carácter ingresado sea mostrado en el TextBox
            }
        }
    }
}
