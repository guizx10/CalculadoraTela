using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTela
{
    public partial class Form1 : Form
    {
        Model modelo;
        public Form1()
        {
            InitializeComponent();
            modelo = new Model();
        }//fim do construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Somar(num1, num2);
            }
            
        }//fim do somar

        private void button4_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Multiplicar(num1, num2);
            }
        }//fim do multiplicar

        private void button3_Click(object sender, EventArgs e)
        {
            if(numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                if (modelo.Dividir(num1, num2) == -1)
                {
                    resultado.Text = "Impossivel Dividir";

                }
                else
                {
                    resultado.Text = "" + modelo.Dividir(num1, num2);
                }

            }
        }//fim do dividir

        private void button5_Click(object sender, EventArgs e)
        {

            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                numeroUm.Text = "";
                numeroDois.Text = "";
                resultado.Text = "";
            }
           
        }//fim do limpar

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numeroUm_TextChanged(object sender, EventArgs e)
        {

        }//fim do numero um 

        private void numeroDois_TextChanged(object sender, EventArgs e)
        {

        }//fim do numero dois

        private void subtrair_Click(object sender, EventArgs e)
        {

            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Subtrair(num1, num2);
            }
        }//fim do subtrair

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }//fim do resultado
    }//fim da classe
}//fim do projeto
