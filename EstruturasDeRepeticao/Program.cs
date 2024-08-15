using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeRepeticao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exibindo números de 1 a 100");
            int contador = 1;

            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine("Fim do programa");
            Console.ReadKey();
        }
    }
}
