using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectodosJarodBolanos
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
        public struct Datos
        {
            public string jugadoruno;
            public string jugadordos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            button1.Enabled = false;
            //MessageBox.Show("MUESTRA MENSAJE");
            textBox1.Enabled = true;
            textBox1.Visible = true;
            label1.Visible = true;
            textBox2.Enabled = true;
            textBox2.Visible = true;
            label2.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            MessageBox.Show("El jugador contrario será la computadora");
            textBox1.Enabled = true;
            textBox1.Visible = true;
            label1.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Enabled == true && (textBox2.Text == "Computadora" || textBox2.Text == "computadora"|| textBox1.Text == "Computadora" || textBox1.Text == "computadora"))
            {
                MessageBox.Show("Debe ingresar algun nombre, no Computadora");
            }
            else
            {

            Datos jugadores;
            jugadores.jugadoruno = textBox1.Text;
            jugadores.jugadordos = textBox2.Text;

            string jugadorunotex="", jugadordostex="";
            jugadorunotex = textBox1.Text;
            jugadordostex = textBox2.Text;
            if (jugadorunotex==""||jugadordostex=="")
            {
                MessageBox.Show("Escriba el nombre del jugador");
            }
            else
            {    //METODO , CUANDO SE OCULTAN LAS VENTANAS MIENTRAS OTRAS ESTAN ABIERTAS Y SE REACOMODARON LOS BOTONES
                this.Hide();
                gamejugadores segundoform = new gamejugadores(jugadores);
                // SE DEFINE CLASE PARA MOSTRARLA, ES EQUIVALENTE A ESTABLECER LA VISIBLE PROPIEDAD
                    segundoform.Show();
            }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {// CIERRA EL FORMS PRINCIPAL
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
