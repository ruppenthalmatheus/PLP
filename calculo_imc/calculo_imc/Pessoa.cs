using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_imc
{
    class Pessoa
    {
        #region Atributos

        public string nome { get; set; }
        public string sexo { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }

        #endregion

        #region Métodos

        public double calculaIMC(double pPeso, double pAltura)
        {
            return pPeso / (Math.Pow(pAltura,2));
        }

        public void escreveResultado(double pIMC, Pessoa pPessoa)
        {
            if (pIMC < 18.5)
            {
                Console.WriteLine("- Informações Pessoais -");
                Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                Console.WriteLine("Nome: "+pPessoa.nome); 
                Console.WriteLine("Sexo: "+pPessoa.sexo);
                Console.WriteLine("Peso: "+pPessoa.peso);
                Console.WriteLine("Altura: "+pPessoa.altura);
                Console.WriteLine(" ");
                Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯ ");
                Console.WriteLine("|   - Resultado IMC -    |");
                Console.WriteLine("|                        | ");
                Console.WriteLine("|  Abaixo do peso ideal  |");
                Console.WriteLine("|________________________|");
            }else if ((pIMC >= 18.5) && (pIMC < 25))
            {
                Console.WriteLine("- Informações Pessoais -");
                Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                Console.WriteLine("Nome: " + pPessoa.nome);
                Console.WriteLine("Sexo: " + pPessoa.sexo);
                Console.WriteLine("Peso: " + pPessoa.peso);
                Console.WriteLine("Altura: " + pPessoa.altura);
                Console.WriteLine(" ");
                Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯ ");
                Console.WriteLine("|   - Resultado IMC -    |");
                Console.WriteLine("|                        | ");
                Console.WriteLine("|     No peso ideal      |");
                Console.WriteLine("|________________________|");
            }else if ((pIMC >= 25) && (pIMC <= 30))
            {
                Console.WriteLine("- Informações Pessoais -");
                Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                Console.WriteLine("Nome: " + pPessoa.nome);
                Console.WriteLine("Sexo: " + pPessoa.sexo);
                Console.WriteLine("Peso: " + pPessoa.peso);
                Console.WriteLine("Altura: " + pPessoa.altura);
                Console.WriteLine(" ");
                Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯ ");
                Console.WriteLine("|   - Resultado IMC -    |");
                Console.WriteLine("|                        | ");
                Console.WriteLine("|  Acima do peso ideal   |");
                Console.WriteLine("|________________________|");
            }else if (pIMC > 30)
            {
                Console.WriteLine("- Informações Pessoais -");
                Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                Console.WriteLine("Nome: " + pPessoa.nome);
                Console.WriteLine("Sexo: " + pPessoa.sexo);
                Console.WriteLine("Peso: " + pPessoa.peso);
                Console.WriteLine("Altura: " + pPessoa.altura);
                Console.WriteLine(" ");
                Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯ ");
                Console.WriteLine("|   - Resultado IMC -    |");
                Console.WriteLine("|                        | ");
                Console.WriteLine("|         Obeso          |");
                Console.WriteLine("|________________________|");
            }
        }

        #endregion


    }
}
