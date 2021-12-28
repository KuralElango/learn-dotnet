using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_And_Date_Coversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;
            float f = 20.254f;
            i=(int)f;
            string name = "   Kuralarasan    ";
            Console.WriteLine("Type Casting "+i);
            string s =i.ToString();
            Console.WriteLine("Type Coversion to string "+s);
            int i2 = Int32.Parse(s);
            Console.WriteLine("Type Conversion to int"+i2);
            Console.WriteLine("String Manipulation Trimming :"+name.Trim());
            Console.WriteLine("String Manipulation lower case :"+name.ToLower());
            Console.WriteLine("String Manipulation Char" + name.ToCharArray());
            Console.WriteLine("String Manipulation Length" + name.Length);

            DateTime dt = DateTime.Now;
            Console.WriteLine("\n\n");
            Console.WriteLine("Current Time" + dt);
            Console.WriteLine("time format {0:t}", dt);
            Console.WriteLine("date format {0:d}", dt);
            Console.WriteLine("time and date format {0:f}",dt);
            Console.WriteLine("Year {0:y}", dt);
            Console.WriteLine("Manual {0:dd-mm-yyyy}",dt);
            Console.WriteLine("Time Zone {0:zz}", dt);

            

        }
    }
}
