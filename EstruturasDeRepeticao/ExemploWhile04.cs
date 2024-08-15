using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeRepeticao
{
    internal class ExemploWhile04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exibindo números do usuário!");
            int contador = 0, numero;

            Console.WriteLine("Digite o fim do intervalo");
            numero = Convert.ToInt32(Console.ReadLine());

            while (contador <= numero)
            {
                if (contador == 4)
                {
                    contador++;
                    //break; // Para
                    continue; // Pula o número
                }
                Console.WriteLine("Numero "+ contador);
                contador++;
                
            }
            Console.WriteLine("Fim do programa");
            Console.ReadKey();
        }
    }
    
}
