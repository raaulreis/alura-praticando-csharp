using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeRaul = 16;
            int quantidadePessoas = 2;

            if (idadeRaul >= 18)
            {
                Console.WriteLine("Raul possui mais de 18 anos");
            }
            else
            {
                Console.WriteLine("Raul não possui mais de 18 anos, não pode entrar");
            }



            Console.ReadLine();
        }
    }
}
