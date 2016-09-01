using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_b
{
    class ex03_b
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int maior = 0;

            for (int i = 1; i <= 5; i++)
            {
                do
                {
                    Console.Write("Informe um número positivo: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Informe um segundo número positivo: ");
                    b = int.Parse(Console.ReadLine());

                    if ((a < 0) || (b < 0))
                        Console.WriteLine("Ambos os números devem ser positivos!\n\n");

                } while ((a < 0) || (b > 0));

                maior = maiorNumero(a, b);

                if (maior != -1)
                {
                    Console.WriteLine("O maior elemento é: " + maior + "\n");
                }
                else
                {
                    Console.WriteLine("Os números são iguais!\n");
                }

            }

            Console.ReadLine();

        }

        static int maiorNumero(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {
                return -1;
            }
        }
    }
}
