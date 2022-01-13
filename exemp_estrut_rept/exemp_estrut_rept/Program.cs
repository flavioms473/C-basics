using System;

namespace exemp_estrut_rept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo = 0;
            int gasolina = 0;
            int alcool = 0; 
            int diesel = 0;

            Console.WriteLine("Digite um codigo (1, 2, 3) ou 4 para finalizar");
            codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                /* if(codigo == 1)
                 {
                     alcool ++;
                 }
                 else if(codigo == 2)
                 {
                      gasolina++;
                 }
                 else if(codigo == 3)
                 {
                     diesel++;
                 }*/

                //  ou switch

                switch (codigo)
                {
                    case 1:
                        alcool++;
                        break;

                     case 2:
                        gasolina++; 
                        break;
                       
                    case 3:
                        diesel++;
                        break;
                }

                Console.WriteLine("Digite um codigo (1, 2, 3) ou 4 para finalizar");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
