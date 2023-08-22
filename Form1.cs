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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void practica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormTrianguloAct3().ShowDialog();
        }

        private void practicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAritmetica().ShowDialog();
        }

        private void practicaDeFormulaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFormulaGeneral().ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void practica4DeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFibonacci().ShowDialog();
        }

        private void practica5DeIlusionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormIlusiones().ShowDialog();
        }

        private void practica6DeIlusiones2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormIlusiones2().ShowDialog();
        }

        private void practica7DeEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEncuesta().ShowDialog();
        }

        private void practica8CatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCatalogo().ShowDialog();
        }
    }
}
