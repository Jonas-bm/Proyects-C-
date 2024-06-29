using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;
        bool nuevoNumero = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (nuevoNumero || tbResultado.Text == "0")
            {
                tbResultado.Text = "";
                nuevoNumero = false;
            }

            tbResultado.Text += boton.Text;
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(tbResultado.Text);

            if(Operador=='+')
            {
                tbResultado.Text=(Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(tbResultado.Text);
            }
            else if (Operador == '-')
            {
                tbResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(tbResultado.Text);
            }
            else if (Operador == 'X')
            {
                tbResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(tbResultado.Text);
            }
            else if (Operador == '/')
            {
                if(Numero2!=0)
                {
                    tbResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(tbResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
            }
            nuevoNumero = true;
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(tbResultado.Text.Length>1)
            {
                tbResultado.Text=tbResultado.Text.Substring(0,tbResultado.Text.Length-1);
            }
            else
            {
                tbResultado.Text = "0";
            }
        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            tbResultado.Text = "0";
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "0";
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if(!tbResultado.Text.Contains("."))
            {
                tbResultado.Text+= ".";
            }
        }
        private void btnSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(tbResultado.Text);
            Numero1 *= -1;
            tbResultado.Text=Numero1.ToString();
        }
        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(tbResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador== '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                tbResultado.Text=Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                tbResultado.Text = Numero1.ToString();
            }
            else
            {
                nuevoNumero = true;
            }
        } 
    }
}
