using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args){
            // if (15 > 18)
            // {
            //     Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAA");
            // }
            // // else if
            // // {
            //         // Mesma coisa
            // // }
            // else
            // {
            //     Console.WriteLine("bbbbbbbbbbbbbbbbbbbbbbbbb");
            // }

            ////////////////////////////////////////////////////////
            
            int time = 16;
            string result = (time < 18) ? "Bom dia!" : "Boa noite!";  // Dessa forma o '?' funciona como if e o ':' como else
            Console.WriteLine(result);
        }
    }
}