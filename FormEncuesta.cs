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
    public partial class FormEncuesta : Form
    {
        public FormEncuesta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procesando Encuesta");
            richTextBox1.Text = "Welcome " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + 
                "\n Fecha de nacimiento: " + dateTimePicker1.Text + "\n Año de nacimiento: " + numericUpDown1.Text + 
                "\n Tu comida favorita es: " + comboBox1.Text + "\n Pelicula favorita es: " + comboBox2.Text
                + "\n Te gusta programar?";
            if (radioButton1.Checked==true)
            {
                richTextBox1.Text += "Guacala";
            }
            if (radioButton2.Checked==true)
            {
                richTextBox1.Text += "No se";
            }
            if (radioButton3.Checked == true)
            {
                richTextBox1.Text += "Me ofende la pregunta";
            }
            if (radioButton4.Checked == true)
            {
                richTextBox1.Text += "Todas las anteriores";
            }
            richTextBox1.Text += "\n Complete la oración: yo soy...";
            if(checkBox1.Checked == true)
            {
                richTextBox1.Text += "\n si";
            }
            if (checkBox2.Checked == true)
            {
                richTextBox1.Text += "\n pasa info para transferir";
            }
            if (checkBox3.Checked == true)
            {
                richTextBox1.Text += "\n AHHHHHHH";
            }
            if (checkBox4.Checked == true)
            {
                richTextBox1.Text += "\n Jenny Rivera";
            }
            if (checkBox5.Checked == true)
            {
                richTextBox1.Text += "\n Chayanne";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEncuesta_Load(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox2.Items[2].ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 2023;
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Jose Roberto";
            textBox2.Text = "Hernandez";
            textBox3.Text = "Acosta";
            dateTimePicker1.Value = new DateTime(2012, 05, 28);
            numericUpDown1.Value = 2012;
            comboBox1.Text = "Chilaquiles";
            comboBox2.Text = comboBox2.Items[1].ToString();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }
    }
}
