using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Work
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 * num2);
            multiply multuplies = new multiply();
            Console.ReadLine();


            Console.WriteLine("press enter to go too addition of numbers");
            Console.WriteLine("Input a number");
            int numa1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number");
            int numa2 = int.Parse(Console.ReadLine());
            Console.WriteLine(numa1 + numa2);
            addition adds = new addition();
            Console.ReadLine();

            Console.WriteLine("press enter to go too subtraction of numbers");
            Console.WriteLine("Input a number");
            int nums1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number");
            int nums2 = int.Parse(Console.ReadLine());
            Console.WriteLine(numa1 + numa2);
            subtraction subs = new subtraction();
            Console.ReadLine();


        }

      
    }

           class multiply
    {
        public static int multiplies(int num1, int num2)
        {
            return (num1 * num2);
        }
    }
    
    class addition
    {
        public static int adds(int numa1, int numa2)
        {
            return (numa1 + numa2);
        }
    }
    class subtraction
    {
        public static int subs(int nums1, int nums2)
        {
            return (nums1 + nums2);
        }
    }

}

