using System;
namespace Uppgift4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "j";

        
            do
            {
                game(); 

              
                Console.WriteLine("\nVill du testa igen? [j]a eller [n]ej?");
                loop = Console.ReadLine().ToLower();
            }
            while (loop != "n");
        }

       
        static void game()
        {
           
            Console.WriteLine("Hur många X per grupp?");
            long XPerGroup = long.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            long OPerGroup = long.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O mönster?");
            long OPatterns = long.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader ska finnas?");
            long rows = long.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {

              
                for (int j = 1; j <= (OPatterns * 2 + 1); j++)
                {

                    
                    if (j % 2 == 1)
                    {
                        for (int k = 0; k < XPerGroup; k++)
                        {
                            Console.Write("X");
                        }
                    }

                    
                    else if (j % 2 == 0)
                    {
                        for (int k = 0; k < OPerGroup; k++) 
                        {
                            Console.Write("O");
                        }
                    }

                    if (j != (OPatterns * 2 + 1))
                    {
                        Console.Write("-");
                    }
                }

          
                Console.WriteLine();
            }
        }
    }
}