using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            int menu = 0;
            float num1 = 0;
            float num2 = 0;
            float resp = 0;

            do
            {
                Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
                Console.WriteLine("|        MENU       |");
                Console.WriteLine("|                   |");
                Console.WriteLine("| 1 - Multiplicação |");
                Console.WriteLine("| 2 - Soma          |");
                Console.WriteLine("| 3 - Divisão       |");
                Console.WriteLine("| 4 - Subtração     |");
                Console.WriteLine("| 5 - Sair          |");
                Console.WriteLine("|___________________|");
                Console.WriteLine("");
                Console.Write("Opção desejada: ");

                do
                {
                    menu = int.Parse(Console.ReadLine());
                    if ((menu < 1) || (menu > 5))
                    {
                        Console.WriteLine("Erro: Opção inválida!");
                    }
                } while ((menu < 1) || (menu > 5));

                if (menu != 5)
                {
                    Console.WriteLine("");
                    Console.Write("Informe o primeiro número: ");
                    num1 = float.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo número: ");
                    num2 = float.Parse(Console.ReadLine());
                }

                switch (menu)
                {
                    case 1:
                        resp = mult(num1, num2);
                        break;
                    case 2:
                        resp = soma(num1, num2);
                        break;
                    case 3:
                        resp = div(num1, num2);
                        break;
                    case 4:
                        resp = sub(num1, num2);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Encerrando o programa...");
                        Console.ReadLine();
                        break;
                }

                Console.WriteLine("\nA resposta da operação é: " + resp + "\n");

            } while (menu != 5);

        }

        //Funções

        /// <summary>
        /// Por: Matheus Ruppenthal
        /// <para>Data: 24/08/2016</para>
        /// <para>Função de multiplicação. Faz a multiplicação de dois números.</para>
        /// </summary>
        /// <param name="x">Passa um valor decimal</param>
        /// <param name="y">Passa um segundo valor decimal</param>
        /// <returns>Retorna um float com o resultado da multiplicação.</returns>
        static float mult(float x, float y)
        {
            return x * y;
        }

        /// <summary>
        /// Por: Matheus Ruppenthal
        /// <para>Data: 24/08/2016</para>
        /// <para>Função de soma. Faz a soma de dois números.</para>
        /// </summary>
        /// <param name="x">Passa um número decimal</param>
        /// <param name="y">Passa um segundo número decimal</param>
        /// <returns>Retorna um float com o resultado da soma.</returns>
        static float soma(float x, float y)
        {
            return x + y;
        }

        /// <summary>
        /// Por: Matheus Ruppenthal
        /// <para>Data: 24/08/2016</para>
        /// <para>Função de subtração. Faz a subtração de dois números.</para>
        /// </summary>
        /// <param name="x">Passa um valor decimal</param>
        /// <param name="y">Passa um segundo valor decimal</param>
        /// <returns>Retorna um float com o resultado da subtração.</returns>
        static float sub(float x, float y)
        {
            return x - y;
        }

        /// <summary>
        /// Por: Matheus Ruppenthal
        /// <para>Data: 24/08/2016</para>
        /// <para>Função de divisão. Faz a divisão de dois números.</para>
        /// </summary>
        /// <param name="x">Passa um valor decimal</param>
        /// <param name="y">Passa um segundo valor decimal</param>
        /// <returns>Retorna um float com o resultado da divisão.</returns>
        static float div(float x, float y)
        {
           return x / y;
        }

    }
}
