using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroX = 0;
            int numeroY = 0;

            Console.Write("Digite um Número para X: ");
            numeroX = int.Parse(Console.ReadLine());

            Console.Write("Digite um Número para Y: ");
            numeroY = int.Parse(Console.ReadLine());

            if (numeroX > numeroY)
            {
                Console.WriteLine("Número X é maior!");
            }

            else
            {
                Console.WriteLine("Número Y é maior!");
            }
        }
    }
}
