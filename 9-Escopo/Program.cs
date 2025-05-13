using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeRaul = 16;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Raul esta acompanhado!";
            }
            else
            {
                mensagemAdicional = "Raul não está acompanhado";
            }

            if (idadeRaul >= 18 || acompanhado == true)
            {
                Console.WriteLine("Raul pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Raul não pode entrar");
            }



            Console.ReadLine();
        }
    }
}
