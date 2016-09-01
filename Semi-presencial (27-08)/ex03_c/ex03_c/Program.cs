using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int totalSoma = 0;

            for (int i = 1; i <= 5; i++)
            {
                x = lePositivo();
                totalSoma = somatorio(x);
                Console.WriteLine("A soma é: " + totalSoma + "\n");
            }
        }

        static int lePositivo()
        {
            int a = 0;

            do
            {
                Console.Write("Informe um numero positivo: ");
                a = int.Parse(Console.ReadLine());

                if (a < 0)
                {
                    Console.WriteLine("O numero deve ser positivo!\n\n");
                }

            } while (a < 0);

            return (a);
        }

        static int somatorio(int n)
        {

            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                total = total + i;
            }

            return (total);
        }

    }
}
