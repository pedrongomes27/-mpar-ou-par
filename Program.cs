using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ímpar_ou_par
{
    class Program
    {
        static void Main(string[] args)
        {
            int numImpares = 0;
            int numPares = 0;
            Random randNum = new Random();
            List<int> numeros = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numeros.Add(randNum.Next());
            }

            for (int j = 0; j < 100; j++)
            {
                if (numeros[j] % 2 == 0)
                {
                    numPares++;
                }
                else
                {
                    numImpares++;
                }
                Console.WriteLine(numeros[j]);
            }

            Console.WriteLine("Foram " + numPares + " pares");
            Console.WriteLine("Foram " + numImpares + " ímpares");
            Console.ReadKey();
        }
    }
}