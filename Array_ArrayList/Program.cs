using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            //ways of initiating array

            Console.WriteLine("***********Arrays********\n");
            int[] even = new int[4] {2,4,6,8};
            int[] odd = {1,3,5,7};
            var prime = new int[4] {1,2,3,5};
            for(int i = 0; i < even.Length; i++)
            { Console.WriteLine("Even Numbers:{0}", even[i]); }
            for(int i = 0; i < odd.Length;i++)
            { Console.WriteLine("Odd Numbers:" + odd[i]); }
            for(int i=0; i < prime.Length;i++) 
            { Console.WriteLine("Prime Numbers:" + prime[i]); }
            Console.WriteLine("Sum of the numbers:"+even.Sum());
            Console.WriteLine("Maximum value of the array:"+odd.Max());
            Console.WriteLine("Average:"+prime.Average());
           
            Array.Reverse(odd);
            Array.ForEach(odd, n => Console.WriteLine(n));
            Array.Reverse(even);
            Console.WriteLine("Reversed Even numbers");
            foreach (var item in even)
                Console.WriteLine(item);

            //multidimensional array

            int[,] twodim =
            {
                {8,2 },
                {9,3 },
                {2,7 }
            };
            for(int i = 0;i < 3;i++)
            {
                for(int j = 0;j < 2;j++)
                {
                    Console.WriteLine(twodim[i,j]);
                }
            }
            
            



            Console.WriteLine("\n*************ArrayList**********\n");

            ArrayList arlist = new ArrayList();
            arlist.Add(5);
            arlist.Add("HELLO");
            arlist.Add("");
            foreach(var element in arlist)
                Console.WriteLine(element+",");
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add("new array");
            arrayList.Add(686);
            foreach (var item in arrayList)
                Console.Write(item + ",");
            Console.WriteLine("\nJoining two array list");
            arlist.AddRange(arrayList);
            foreach(var item in arlist)
                Console.Write(item+",");
            Console.WriteLine("\nRemoving An element");
            arlist.Remove("");
            foreach (var item in arlist)
                Console.Write(item + ",");
            Console.WriteLine("using contains");
            Console.WriteLine(arlist.Contains("new array"));
        }
    }
}
