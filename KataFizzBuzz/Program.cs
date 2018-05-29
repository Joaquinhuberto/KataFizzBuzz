using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFizzBuzz
{
    public class KataFizzBuzz
    {
        static void Main(string[] args)
        {
            for (int x = 0 ; x<=100; x++)
            {
                
                Console.WriteLine( x + " -> " + fizzBuzz(x) );
   
            }
            String name = Console.ReadLine();
        }
        public static string fizzBuzz(int x)
        {
            if (x % 15 == 0)
            {
                return "FizzBuzz";

            }
            else if (x % 3 == 0)
            {
                return "Fizz";
            }
            else if (x % 5 == 0)
            {
                return "Buzz";
            }

            return x.ToString();
        }
    }



    /*
                 if(x % 3 == 0 && x % 5 == 0)
            {
                return "FizzBuzz";
            }else if(x % 3 == 0)
            {
                return "Fizz";
            }else if(x % 5 == 0)
            {
                return "Buzz";
            }
           

            return x.ToString();
     
     */

}
