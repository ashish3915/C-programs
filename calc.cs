using System;

namespace ConsoleApp2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Operation You want to Perform:");
            Console.WriteLine("1. Addition.\n2. Subtraction.\n3. Multiplication.\n4. Division.\n0. Exit.");

            while (true)
            {
                Console.WriteLine("\nEnter Your Choice:");
                int action = Convert.ToInt32(Console.ReadLine());
                double result = 0;

                switch (action)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Enter First Number:");
                            double input1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Second Number:");
                            double input2 = Convert.ToDouble(Console.ReadLine());
                            result = Addition(input1, input2);
                            Console.WriteLine("Result is {0}", result);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter First Number:");
                            double input1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Second Number:");
                            double input2 = Convert.ToDouble(Console.ReadLine());
                            result = Subtraction(input1, input2);
                            Console.WriteLine("Result is {0}", result);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter First Number:");
                            double input1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Second Number:");
                            double input2 = Convert.ToDouble(Console.ReadLine());
                            result = Multiplication(input1, input2);
                            Console.WriteLine("Result is {0}", result);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter First Number:");
                            double input1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Second Number:");
                            double input2 = Convert.ToDouble(Console.ReadLine());
                            result = Division(input1, input2);
                            Console.WriteLine("Result is {0}", result);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input:");
                            break;
                        }
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
