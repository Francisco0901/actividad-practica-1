using System;

namespace proyecto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 6;
            int b;
            b = 9;
            int c;
            c = 4;
            Console.WriteLine("secuencias bca, aacb y bcbc de a=6, b=9 y c=4");
            //bca
            Console.WriteLine("primera secuencia:");
            Console.Write(b);
            Console.Write(c);
            Console.WriteLine(a);
            //aacb
            Console.WriteLine("segunda secuencia");
            Console.Write(a);
            Console.Write(a);
            Console.Write(c);
            Console.WriteLine(b);
            //bcbc
            Console.WriteLine("tercera secuencia");
            Console.Write(b);
            Console.Write(c);
            Console.Write(b);
            Console.Write(c);
        }
    }
}
