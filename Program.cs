using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number__discret_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int y = int.Parse(Console.ReadLine());
            bool prime =true;
            Console.WriteLine("the prime number is : ");
            for (int i =x; i <=y; i++)
            {
                for (int j = 2; j < y; j++)
                {
                    if (i!=j && i%j==0)
                    {
                        prime = false;
                        break;
                        }
                    if (i == 1)
                        prime = false;

                  }
                if (prime)
                    Console.WriteLine(i);
                prime = true;
            }

        }
    }
}
