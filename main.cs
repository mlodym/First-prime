using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long data = 600851475143;
            
            for( long i= data; i>=3 ; i--)
            {
                if(isPrime(i))
                {
                    Console.WriteLine("The biggest first prime is: {0}", i);
                    break;
                }
            }

            Console.ReadKey();
        }

        public static bool isPrime(long number)
        {
            double temp_number = Math.Sqrt(number);

            for (int i = 3; i < temp_number; i++)
            {
                if (number % i == 0) return false;
            }         
         return true;
        }
    }
}
