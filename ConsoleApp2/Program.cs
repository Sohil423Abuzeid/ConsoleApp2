using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String SP = " ";
            string ST = "#"  ;
            Console.WriteLine("Entre  number");
            int C = 1,G = 1 ;
            int D = Convert.ToInt32(Console.ReadLine());
           
            for (int X = D ; X > 0; X = X - 2)
            {

                for (int B = (X / 2); B > 0; B--)
                {
                    Console.Write(SP);
                }

                for (int A = C; A > 0; A--)
                {
                    Console.Write(ST);
                }

                for (int V = (X / 2); V > 0; V--)
                {
                    Console.Write(SP);
                }
                Console.WriteLine("");
                C = C +2;
            }
            for ( int F = D-2; F > 0 ; F -=2  )
            {
                
                for (int B = G; B > 0; B--)
                {
                    Console.Write(SP);
                }

                for (int A = F; A > 0; A-- )
                {
                    Console.Write(ST);
                }

                for (int V = G ; V > 0; V--)
                {
                    Console.Write(SP);
                }
                Console.WriteLine("");
                G = G + 1;



            }
           
        }
    }
}
