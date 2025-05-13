using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeRaul = 16;
            int quantidadePessoas = 2;
            bool acompanhado = false;

            //bool acompanhado = quantidadePessoas >= 2;
            // Pipe Pipe || => (OR) Quando uma OU outra variável é verdadeira
            // && = (AND) Quando ambas as variáveis são verdadeiras

            if (idadeRaul >= 18 && acompanhado == true)
            {
                Console.WriteLine("Raul pode entrar");
            }
            else
            {
                Console.WriteLine("Raul não pode entrar");
            }



            Console.ReadLine();
        }
    }
}
    

