using System;

namespace Lab4ex6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Scrieti o functie recursiva care va calcula al n-lea element din sirul lui Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul*/

            Console.WriteLine("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());

            var nLeaElement = ReturneazaNleaElementFibonacci(n);

            Console.WriteLine("Elementul din sirul lui Fibonacci de pe pozitia " + n + " este " + nLeaElement);

        }

        static int ReturneazaNleaElementFibonacci(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;

            int numar = ReturneazaNleaElementFibonacci(n - 1) + ReturneazaNleaElementFibonacci(n - 2);

            return numar;
        }
        
    }
}
