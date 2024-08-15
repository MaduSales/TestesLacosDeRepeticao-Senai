using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeRepeticao
{
    internal class ExemploWhile03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exibindo números de 100 a 1");
            int contador = 100;

            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--;
            }

            Console.WriteLine("Fim do programa");
            Console.ReadKey();
        }
    }
}
