using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
           
            string Apellido = textBox1.Text;
            string Nombre = textBox2.Text;
            string Edad = textBox3.Text;
            string Direccion = textBox4.Text; 
            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.Red; 

            }
            else
            {
                textBox1.BackColor = System.Drawing.SystemColors.Control; 
            }
            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.Red;
            }
            else
            {
                textBox2.BackColor = System.Drawing.SystemColors.Control; 
            }
            if(textBox3.Text == "")
            {
                textBox3.BackColor = Color.Red;
            }
            else
            {
                textBox3.BackColor = System.Drawing.SystemColors.Control; 
            }
            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.Red; 
            }
            else
            {
                textBox4.BackColor = System.Drawing.SystemColors.Control; 
            }
            txtMostrar.Text = "Apellido y nombre" + Apellido + " " + Nombre +
                                "Edad: " + Edad + " Dirección: " + Direccion; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
