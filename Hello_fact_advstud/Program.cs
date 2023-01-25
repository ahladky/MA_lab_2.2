using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            //Call fact() method to calculate
            Console.WriteLine("fact1 - " + fact1(5));
            Console.WriteLine("fact2 - " + fact2(5));
            
            Console.ReadLine();
        }

        static int fact1(int x)
        {
            int y = 1;
            for (int i = 1; i <= x; i++)
            {
                y = y*i;
            }
            return y;
        }


        static int fact2(int x)
        {
            int y = (x == 0 || x == 1) ? 1 : x * fact2(x - 1);
            return y;
        }

        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator

    }

    

}
