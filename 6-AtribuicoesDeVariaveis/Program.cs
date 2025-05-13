using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o preojeto 6");

            int idade = 22;
            int idadeRaul = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeRaul);

            Console.ReadLine();
        }
    }
}
