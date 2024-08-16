using System;
using classes;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mario = new Person();
            Mario.PrimeiroNome = "Mario";
            Mario.SegundoNome = "Santos";
            Mario.Introduce();
            Mario.CalculoIdade();
        }           
    }
}