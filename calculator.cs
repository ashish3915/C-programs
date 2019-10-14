using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Operation You want to Perform:");
            Console.WriteLine("1. Addition.\n2. Subtraction.\n3. Multiplication.\n4. Division.\n0. Exit.");
            
            while (true)
            {
                Console.WriteLine("\nEnter Your Choice:");
                int action = Convert.ToInt32(Console.ReadLine());

                if (action == 0)
                {
                    Environment.Exit(0);
                }

                if (action == 1 || action == 2 || action == 3 || action == 4)
                {
                    Console.WriteLine("Enter First Number:");
                    double input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Second Number:");
                    double input2 = Convert.ToDouble(Console.ReadLine());

                    double result=0;
                    if (action == 1)
                    {
                        //Console.WriteLine("Add");
                        result = Addition(input1, input2);
                        Console.WriteLine("Result is {0}", result);
                    }
                    if (action == 2)
                    {
                        //Console.WriteLine("Sub");
                        result = Subtraction(input1, input2);
                        Console.WriteLine("Result is {0}", result);
                    }
                    if (action == 3)
                    {
                        //Console.WriteLine("Mul");
                        result = Multiplication(input1, input2);
                        Console.WriteLine("Result is {0}", result);
                    }
                    if (action == 4)
                    {
                        //Console.WriteLine("Div");
                        result = Division(input1, input2);
                        Console.WriteLine("Result is {0}", result);
                    }
                }

                else
                {
                    Console.WriteLine("Invalid Input.");
                    continue;
                }
            }
            //Console.ReadKey();
        }

        public static double Addition(double input1, double input2)
        {
            double result = input1 + input2;
            return result;
        }
        public static double Subtraction(double input1, double input2)
        {
            double result = input1 - input2;
            return result;
        }
        public static double Multiplication(double input1, double input2)
        {
            double result = input1 * input2;
            return result;
        }
        public static double Division(double input1, double input2)
        {
            double result = input1 / input2;
            return result;
        }
    }
}
