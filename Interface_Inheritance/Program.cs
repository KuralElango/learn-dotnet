using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance
{
    public interface IAdd
    {
        void IAddition();
    }
    public class Add : IAdd
    {
        public void IAddition()
        {
           Console.WriteLine("Addition process is over written") ;
        }

    }
    public interface ISub
    {
        void ISubtraction();
    }
    public class Sub : ISub
    {
        public void ISubtraction()
        {
            Console.WriteLine("Subtraction process is over written");
        }
    }
    public class AddSub:IAdd,ISub
    {
        Add add = new Add();
        Sub sub = new Sub();
        public void IAddition()
        {
           add.IAddition();
        }
        public void ISubtraction()
        {
           sub.ISubtraction();
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            AddSub addsub = new AddSub();
            addsub.IAddition();
            addsub.ISubtraction();
        }
    }
}
