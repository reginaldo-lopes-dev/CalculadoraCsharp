using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacegrafica
{
    public partial class Form1 : Form
    {
        Double valor,valor1,valor2;
        Double resultado;
        int operacao;
        public Form1() => InitializeComponent();

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            valor = 0;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            valor = 9;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            valor = 1;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Csbt2_Click(object sender, EventArgs e)
        {
            valor = 2;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Csbt3_Click(object sender, EventArgs e)
        {
            valor = 3;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Csbt4_Click(object sender, EventArgs e)
        {
            valor = 4;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Csbt5_Click(object sender, EventArgs e)
        {
            valor = 5;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Csbt6_Click(object sender, EventArgs e)
        {
            valor = 6;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Csbt7_Click(object sender, EventArgs e)
        {
            valor = 7;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Csbtmenos_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(cstb.Text);
            operacao = 2;
            cstb.Clear();
        }

        private void Csbtmult_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(cstb.Text);
            operacao = 3;
            cstb.Clear();
        }

        private void Csbtdiv_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(cstb.Text);
            operacao = 4;
            cstb.Clear();
        }

        private void Csbtquad_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(cstb.Text);
            operacao = 5;
            cstb.Clear();
            resultado = valor1 * valor1;
            cstb.Text = resultado.ToString();
        }

        private void Csbtigual_Click(object sender, EventArgs e)
        {
            if (operacao == 5)
            {
                resultado = valor1 * valor1;
                cstb.Text = resultado.ToString();
            }
            else {
                valor2 = Double.Parse(cstb.Text);
                if (operacao == 1)
                {
                    resultado = valor1 + valor2;
                    cstb.Text = resultado.ToString();
                } else if (operacao == 2)
                {
                    resultado = valor1 - valor2;
                    cstb.Text = resultado.ToString();
                }
                else if (operacao == 3)
                {
                    resultado = valor1 * valor2;
                    cstb.Text = resultado.ToString();
                }
                else if (operacao == 4)
                {
                    resultado = valor1 / valor2;
                    cstb.Text = resultado.ToString();
                }
            }
        }

        private void Csbt8_Click(object sender, EventArgs e)
        {
            valor = 8;
            cstb.Text = cstb.Text + valor.ToString();
        }

        private void Csbtmais_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(cstb.Text);
            operacao = 1;
            cstb.Clear();
        }
    }
}
