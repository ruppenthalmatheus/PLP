using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    class Program
    {

        public static void Main(string[] args)
        {
            int n = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe um número inteiro: ");
                n = int.Parse(Console.ReadLine());
                n = absoluto(n);

                Console.Write("O absoluto do número informado é: " + n + "\n\n");
            }

            Console.ReadLine();

        }

        public static int absoluto(int n)
        {
            if (n >= 0)
            {
                return n;
            }
            else
            {
                return (n * -1);
            }
        }
        

    }

}
