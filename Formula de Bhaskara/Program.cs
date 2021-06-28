using System;
using System.Numerics;
using System.Globalization;


namespace Formula_de_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de (a)");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor de (b)");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de (c)");
            int c = int.Parse(Console.ReadLine());

            double delta, x1, x2;

            delta = Math.Pow(b, 2.0) - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(" O valor de delta = " + delta);
            Console.WriteLine(" O valor de x1 = " + x1);
            Console.WriteLine(" O valor de x2 = " + x2.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
