using System;

namespace currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {
                    string resposta ;
            do
            {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("--Conversor Monetário--");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-- Dólar para Real -- [1]");
            Console.WriteLine("-- Real para Dólar -- [2]");
            Console.WriteLine("-- Euro para Real -- [3]");
            Console.WriteLine("-- Real para Euro -- [4]");
            int opcao = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-- Insira o valor para conversão :");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
           switch (opcao)
           {
                   case 1: Console.WriteLine(Conversor.DolarParaReal());
                   break;

                   case 2:Console.WriteLine(Conversor.RealParaDolar());
                   break;

                   case 3 : Console.WriteLine(Conversor.EuroParaReal());
                   break;

                   
                   case 4 : Console.WriteLine(Conversor.RealParaEuro());
                   break;
               default:
                   break;
           }
           
                Console.WriteLine("deseja repetir a operação? sim/não");
                resposta = Console.ReadLine();
            } while (resposta == "sim");
            
            
            
            
        }
    }
}
