using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioII
{
    class Program
    {
        static void Main(string[] args)
        {
            int registro = 691;

            for (int i = 1; i <= registro; i++)
            {
                if (i % 3 == 0 && num_Primo(i))
                {
                    Console.WriteLine(i + " - Es primo y es divisible por 3");
                }
                else if (num_Primo(i))
                {
                    Console.WriteLine(i + " - Es primo");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " - Es divisible por 3");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(true);
        }

        static bool num_Primo(int numero)
        {
            bool resultado = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % 1 == 0)
                {
                    resultado = false;
                }
            }
            return resultado;

        }
    }
}
