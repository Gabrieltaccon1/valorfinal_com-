using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor=10;
            double porcetagem=5;
            double valorfinal;
            double.Parse(Console.ReadLine()); 

           
            valorfinal = (porcetagem * valor / 100);

            valorfinal = valor * (porcetagem / valor );
                
           
                

           Console.WriteLine("O valor final do produto é: " + valorfinal);
          

          

            
            
            
        }

    }
    }

