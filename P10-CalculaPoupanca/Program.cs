﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;


            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após" + contadorMes + "meses, você terá R$" + valorInvestido);

            //contadorMes = contadorMes + 1;
            //ContadorMes += 1;
            //++ só pode ser utilizado para substituir +=1;
            contadorMes++;
            
            Console.ReadLine();
        }
    }
}
