using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{

    public class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your 1st Number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your 2nd Number:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing:{0}",a/b);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            finally
            {
                Console.WriteLine("Exception Handled if any occured: Press Enter to continue");

            }





            Console.WriteLine("\n\n******************User Defined Exception******************\n");
            var cars = new ArrayList() { "sedan","hatchback","suv","compact suv"};
            Console.WriteLine("Welcome! Enter the type of car you need to rent:");
            string ordergiven = Convert.ToString(Console.ReadLine());
            ordergiven = ordergiven.ToLower();
            try
            {
                if(cars.Contains(ordergiven))
                {
                    Console.WriteLine("Your car booking is successful.");
                }
                else
                {
                    throw (new OutOfStackException("This kind of car is not available"));
                }
            }
            catch(OutOfStackException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();
            }

        }
    }
    public class OutOfStackException : Exception
    {
        public OutOfStackException(String message)
            : base(message) { }
    }
}
