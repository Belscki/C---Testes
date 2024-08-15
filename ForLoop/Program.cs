using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 10;

            for(int i = 1; i <= linhas; i++)
                {
                    for(int j = 1; j<= i; j++)
                    {
                        Console.Write("*");
                    }
                Console.WriteLine();
                }
            
            // foreach para percorrer arrays
            // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            // foreach (string i in cars) 
            // {
            //   Console.WriteLine(i);
            // } 
        }
        
    }
}