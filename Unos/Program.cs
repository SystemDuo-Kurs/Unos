using System;

namespace Unos
{
    class Program
    {
        static void Main(string[] args)
        {
            int bbroj = 5;
            string istoBroj = "5";
            Console.WriteLine(bbroj + 3);
            Console.WriteLine(istoBroj + 3);

            Console.WriteLine("Upisi broj: ");
            int broooj = int.Parse(Console.ReadLine());
            Console.WriteLine($"{broooj} plus 12 jeste {broooj + 12}");

            string unos;
            int broj = 1;
            do
            {
                broj++;
                Console.WriteLine($"Broj je sada {broj}, da li zelite da nastavite?");
                unos = Console.ReadLine();
            } while (unos == "da");
        }
    }
}
