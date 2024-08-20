using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número entre 1 e 26:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero) && numero >= 1 && numero <= 26)
        {
            char letra = (char)('A' + numero - 1);
            Console.WriteLine($"A letra correspondente ao número {numero} é: {letra}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número entre 1 e 26.");
        }

    }
}