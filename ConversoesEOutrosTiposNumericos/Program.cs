using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4: ");

            //O int é um tipo de variável de 32 bits
            //Quando fazemos o casting, estamos pedindo ao C# que ache uma forma de transformar o valor 
            //no lado direito do (int), no nosso caso, a variável salario, em inteiro. Dessa forma o C# 
            //transformará double para int.
            double salario = 3111.77;
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //O long é um tipo de variavel de 64 bits
            long idade = 12000000000;

            //O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 150;

            Console.WriteLine("Fim da execução. Pressione ENTER para sair... ");
            Console.ReadLine();
        }
    }
}
