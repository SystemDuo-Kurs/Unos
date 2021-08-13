using System;

namespace Unos
{
    class Program
    {
        static void Main(string[] args)
        {
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
