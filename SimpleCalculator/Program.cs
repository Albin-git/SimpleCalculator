using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Calculator
    {
        public static double result = 0;
        public static double Addition(double num1, double num2) //Addition
        {
            double result = num1 + num2;
            return result;
        }
        
        public static double Addition1(double num) //Addition med en parameter - (Method Overloading)
        {

            return result + num;
        }
        

        public static double Subtracion(double num1, double num2)//Subtraktion
        {
            double result = num1 - num2;
            return result;
        }

        public static double Subtracion1(double num1) // Subtraktion med en parameter
        {
            return result - num1;
        }
        public static double Division(double num1, double num2)//Division
        {
            double result = num1 / num2;
            return result;
        }

        public static double Division1(double num1) // Division med en paramter
        {
            return result / num1;
        }
        public static double Multiplikation(double num1, double num2)// Multiplikation
        {
            double result = num1 * num2;
            return result;
        }
        
        public static double Multiplikation1(double num1) // Multiplikation med en parameter
        {
            return result * num1;
        }

        


        static void Main(string[] args)
        {

            Console.WriteLine("Enter the steps to execute");
            Console.Write("---------------------------------\n");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Division");
            Console.WriteLine("Press 4 for Multiplication");

            Console.Write("---------------------------------\n");
            double operation = Convert.ToDouble(Console.ReadLine());
            Console.Write("---------------------------------\n");
            Console.WriteLine("Enter your first number: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("---------------------------------\n");
            Console.WriteLine("Enter your second number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            double result = 0 ;
            
            switch (operation)
            {
                case 1:
                    {
                        result = Addition(input1, input2);
                        result = Addition1(input1);
                        break;
                            
                    }
                case 2:
                    {
                        result = Subtracion(input1, input2);
                        result = Subtracion1(input1);
                        break;
                       
                    }

                case 3:
                    {
                        result = Division(input1, input2);
                        result = Division1(input1);
                        break;
                    }
                case 4:
                    {
                        result = Multiplikation(input1, input2);
                        result = Multiplikation1(input1);
                        break;

                       
                    }

                default:
                Console.WriteLine("Wrong Input! Try again!");
                    break;
                    
            }
            Console.Write("---------------------------------\n");
            
            Console.WriteLine("Result: {0}",result);
            Console.ReadLine();
            
            
            }
        }
    }
