using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTela
{
    class Model
    {
        public Model() 
        { 
        
        }//fim do construtor

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }//fim do somar

        public int Subtrair (int num1, int num2) 
        { 
            return num1 - num2;
        }//fim do subtrair

        public int Multiplicar (int num1, int num2) 
        { 
            return num1 * num2;
        }//fim do multiplicar       

        public int Dividir (int num1, int num2) 
        {
            if(num2== 0)
            {
                return -1;

            }
            else
            {
                return num1 / num2;
            }
        }

    }//fim da classe
}//fim do projeto 
