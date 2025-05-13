using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //utilizando character (char)
            char primeiraLetra = 'A';
            Console.WriteLine(primeiraLetra);

            //charactere ' ' tambem é um caractere válido
            char espaco = ' ';
            Console.WriteLine(primeiraLetra);

            //Casting - int para char
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            //juntando um número inteiro (int) com char
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2025;
            string cursosProgramacao =
              @" - .NET
              - Java
              - Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            
            Console.ReadLine();
        }
    }
}
