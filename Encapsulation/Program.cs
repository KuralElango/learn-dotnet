using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Based
    {
        private static string name;
        private static int age;
        private static long phnNo;
        public void print()
        {
            Console.WriteLine("Your name is" + name);
            Console.WriteLine("Your age is" + age);
            Console.WriteLine("Your phone number is" + phnNo);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public long PhnNo
        {
            get { return phnNo; }
            set { phnNo = value; }
        }
    } 
         

    public class Program
    {
        static void Main(string[] args)
        {
            Based based=new Based();
            based.Name = "Kural";
            based.Age = 26;
            based.PhnNo = 948794466l;
            based.print();


        }
    }
}
