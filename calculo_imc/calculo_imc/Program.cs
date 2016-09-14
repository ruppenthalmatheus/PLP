using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            char r = 'N';

            do
            {
                Console.WriteLine("---- CÁLCULO DE IMC ----\n");
                Console.Write("Informe seu nome: ");
                p.nome = Console.ReadLine();
                Console.Write("Informe seu sexo: ");
                p.sexo = Console.ReadLine();
                Console.Write("Informe seu peso: ");
                p.peso = double.Parse(Console.ReadLine());
                Console.Write("Informe sua altura: ");
                p.altura = double.Parse(Console.ReadLine());
                Console.Clear();

                p.escreveResultado(p.calculaIMC(p.peso, p.altura), p);

                Console.Write("\nDeseja repetir o teste? (S/N): ");
                r = char.ToUpper(char.Parse(Console.ReadLine()));

                if (r.Equals('S')) {
                    Console.Clear();
                }

            } while (r.Equals('S'));

            Console.ReadLine();
        }
    }
}
