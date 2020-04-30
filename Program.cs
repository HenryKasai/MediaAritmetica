using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira três números e veja a média aritmética resultante.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Primeiro número:");
            string primeiro = Console.ReadLine();
            decimal primeiro1 = Convert.ToDecimal(primeiro);

            Console.Write("Segundo número:");
            string segundo = Console.ReadLine();
            decimal segundo1 = Convert.ToDecimal(segundo);

            Console.Write("Terceiro número:");
            string terceiro = Console.ReadLine();
            decimal terceiro1 = Convert.ToDecimal(terceiro);

            decimal result = primeiro1 + segundo1 + terceiro1;
            decimal resultfinal = result / 3;
 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A média aritmética entre os números " + primeiro1 + ", " + segundo1 + ", " + terceiro1 + " é: ");
            Console.WriteLine(resultfinal);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();





        }
    }
}
