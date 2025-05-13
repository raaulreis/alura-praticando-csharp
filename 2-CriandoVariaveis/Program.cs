using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            
            int idade = 22;
            Console.WriteLine("Sua idade é " + idade + "!");

            idade = 11 + 11;
            Console.WriteLine("Sua idade é " + idade + "!");

            idade = 12 * 12;
            Console.WriteLine("Sua idade é " + idade + "!");

            idade = 22 / 2;
            Console.WriteLine("Sua idade é " + idade + "!");
            
            Console.WriteLine("Execução Finalizada. Tecle ENTER para sair...  ");
            Console.ReadLine();
        }
    }
}
