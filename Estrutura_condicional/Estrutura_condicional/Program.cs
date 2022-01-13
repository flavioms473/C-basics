using System;
using System.Globalization;

namespace Estrutura_condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Digite um numero: ");
             int x = int.Parse(Console.ReadLine());

             if( x >= 0)
             {
                 Console.WriteLine("Não Negativo");
             }
             else
             {
                 Console.WriteLine("Negativo");
             } */




            // exercicio de multiplos

            /*  Console.WriteLine("Informe Um número para A: ");
              int A = int.Parse(Console.ReadLine());
              Console.WriteLine("Informe Um número para B: ");
              int B = int.Parse(Console.ReadLine());

              if(A % B != 0)
              {
                  Console.WriteLine("Não são Multiplos");
              }
              else
              {
                  Console.WriteLine("São Multiplos");
              }  */



            // exercicio 
            Console.WriteLine("Digite o codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            double qtd = int.Parse(Console.ReadLine());
            double total;

            if (codigo == 1)
            {
              double  total = qtd * 4.0;
            }
            else if (codigo == 2)
            {
               double total = qtd * 4.5;
            }
            else if (codigo == 3)
            {
               double total = qtd * 5.0;
            }
            else if (codigo == 4)
            {
               double total = qtd * 2.0;
            }
            else if (codigo == 5)
            {
                double total = qtd * 1.5;
            }

            Console.WriteLine(total);



        }
    }
}
