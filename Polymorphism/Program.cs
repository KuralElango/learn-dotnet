using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Add
    {
        public virtual int Addition()
        {
            return 3+1;
        }
    }
    public class Program:Add
    {
        public override int Addition()
        {
            return 7 + 3;
        }
        public void Adding(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Adding(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Program prog=new Program();
            prog.Addition();
            prog.Adding(2, 3);
            prog.Adding(2.33f,3.64f);
        }
    }
}
