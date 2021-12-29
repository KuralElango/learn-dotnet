using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cities = new Hashtable();
            cities.Add("TN", "Chennai,Vellore,Salem");
            cities.Add("AP", "Hyderabad,Sriharikota,Guntur");
            cities.Add("KA", "Banglore,Mysore,Hubli");
           
            foreach (DictionaryEntry city in cities)
                Console.WriteLine("Key: {0}, Value: {1}",city.Key,city.Value);
            Console.WriteLine("Updating and removing in HashTable");
            cities["TN"] = "Chennai,Vellore,Salem,Coimbatore,Madurai";
            if (cities.ContainsKey("AP"))
            {
                cities.Remove("AP");
            }

            foreach (DictionaryEntry city in cities)
                Console.WriteLine("Key: {0}, Value: {1}", city.Key, city.Value);

        }
    }
}
