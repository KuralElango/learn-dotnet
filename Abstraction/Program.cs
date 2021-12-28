using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class StateBank
    {
        public abstract void FixedDeposit();
    }
  
    public class AxisBank:StateBank
    {


        public override void FixedDeposit()
        {
            Console.WriteLine("Fixed Deposit has 5% rate");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            AxisBank bank = new AxisBank();
            bank.FixedDeposit();
            Console.ReadLine();
        }
    }
}
