using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BigNumber = 50;
            int val = 0;
            while (val < 10)
                {
                foreach (int value in Enumerable.Range(1, BigNumber))
                {

                    if (value % 3 == 0 && value % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        if (value == BigNumber)
                        {
                            val = 10;
                            Console.ReadLine();
                        }
                    }
                    else if (value % 3 == 0)
                    {
                        Console.WriteLine("Fizz");

                        if (value == BigNumber)
                        {
                            val = 10;
                            Console.ReadLine();
                        }
                    }
                    else if (value % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        if (value == BigNumber)
                        {
                            val = 10;
                            Console.ReadLine();
                        }
                    }
                    else {
                        Console.WriteLine(value);
                        if (value == BigNumber)
                        {
                            val = 10;
                            Console.ReadLine();
                        }
                    }
                    
                }
            
            }
        }
    }
}
