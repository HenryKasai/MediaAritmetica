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
            double primeiro1 = Convert.ToDouble(primeiro);

            Console.Write("Segundo número:");
            string segundo = Console.ReadLine();
            double segundo1 = Convert.ToDouble(segundo);

            Console.Write("Terceiro número:");
            string terceiro = Console.ReadLine();
            double terceiro1 = Convert.ToDouble(terceiro);

            double result = primeiro1 + segundo1 + terceiro1;
            double resultfinal = result / 3;
 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A média aritmética entre os números " + primeiro1 + ", " + segundo1 + ", " + terceiro1 + " é: ");
            Console.WriteLine(resultfinal);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();





        }
    }
}
