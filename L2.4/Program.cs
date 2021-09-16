using System;

namespace L2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 3 == 0)
                Console.WriteLine($"{a} кратно 3");
             else if (a % 2 == 0) 
                Console.WriteLine($"{a} кратно 2 ");
            else
                Console.WriteLine($"{a} NE кратно 2 или 3");
            if ((a % 10 == 0) & (a % 3 != 0))
                Console.WriteLine($"{a} true ");
            else
                Console.WriteLine($"{a} false");
            Console.WriteLine(); 
        }
    }
}
