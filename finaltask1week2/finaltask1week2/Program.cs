using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltask1week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplynums.multiply();
            Addnums.adds();
            Subnums.subs();
        }

        public class Multiplynums
        {
            public static void multiply()
            {
                Console.WriteLine("Input a number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Input a number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 * num2);
                Console.ReadLine();
            }
        }
    }
    public class Addnums
    {
        public static void adds()
        {
            Console.WriteLine("Input a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
    }
}

public class Subnums
{
    public static void subs()
    {
        Console.WriteLine("Input a number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input a number");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(num1 - num2);
        Console.ReadLine();
    }
}
}


