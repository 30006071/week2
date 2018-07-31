using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize1
{
     class Program1
    {
        task1a();

     }
     static void task1a()
        {
            Console.WriteLine("Input a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(multiply1b(num1,num2));
        }

    static int multiply1b (int num1 , int num2){

        return num1 * num2;

}

    
}


