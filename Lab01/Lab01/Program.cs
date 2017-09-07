using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, x = 5, y = 2;
            Console.WriteLine("a = 10, b = 20, x = 5, y = 2");
            Console.WriteLine(" 1. a + b = {0}", a + b);
            Console.WriteLine(" 2. x - b = {0}", x - b);
            Console.WriteLine(" 3. x * b = {0}", x * b);
            Console.WriteLine(" 4. y / a = {0}", y / a);
            Console.WriteLine(" 5. b % y = {0}", b % y);
            Console.WriteLine(" 6. y + 10 % x = {0}", y + 10 % x);
            Console.WriteLine(" 7. a / 3 * 5 = {0}", a / 3 * 5);
            Console.WriteLine(" 8. 9 / 2 * a = {0}", 9 / 2 * a);
            Console.WriteLine(" 9. y % 8 = {0}", y % 8);
            Console.WriteLine("10. 100 * x + y % 2 - a = {0}", 100 * x + y % 2 - a);
            Console.ReadKey();
        }
    }
}
