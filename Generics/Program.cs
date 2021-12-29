using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
    public class Data<T> where T : class
    {
        public T Value { get; set; }
    }
    public class intval<T> where T : struct
    {
        public int Value { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";
            Console.WriteLine("Key1: {0 } Value1: {1}",kvp1.Key,kvp1.Value);

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
            Console.WriteLine("Key2: {0 } Value2: {1}", kvp2.Key, kvp2.Value);

            Data<string> data = new Data<string>();
            data.Value = "I cannot be a primitive datatype because of Generic contsraint";
            Console.WriteLine(data.Value);

            intval<int> num = new intval<int>();
            num.Value = 12;
            Console.WriteLine(num.Value);
        }
    }
}
