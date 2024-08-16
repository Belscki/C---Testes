namespace classes
{
    public class Person
    {
        public string PrimeiroNome;
        public string SegundoNome;
        public int Idade;
        public void Introduce()
        {
            Console.WriteLine("Meu nome é "+ PrimeiroNome + ' ' + SegundoNome);
        }
        public void CalculoIdade()
        {
            Console.WriteLine("Que ano você nasceu?");
            string Ano = Console.ReadLine();

            // Tenta transformar uma string em um 'int'

            // Jeito Longo

            // if(int.TryParse(Ano, out int Idade))
            // {
            //     Console.WriteLine("Você tem " + (2024 - Idade));
            // }
            // else
            // {
            //     Console.WriteLine("Você precisa digitar um numero inteiro");
            // }

            //Jeito Curto
            string Numero = (int.TryParse(Ano, out int Idade)) ? "Você tem " + (2024 - Idade) : "Você precisa digitar um numero inteiro";
            Console.WriteLine(Numero);

        }
    }
}