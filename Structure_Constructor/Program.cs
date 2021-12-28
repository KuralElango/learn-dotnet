using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Constructor
{
    public class Program
    {
        struct Books
        {
            private string name;
            private string author;
            private int id;

            public Books(string n, string a, int i)
            {
                name = n;
                author = a;
                id = i;
            }

            public override string ToString()
            {
                return "The Book name is " + name + "\n" +


                 "The Author Name is " + author + "\n" +

                 "The Book Id is " + id.ToString();
              
            }


            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Author
            {
                get { return author; }
                set { author = value; }
            }

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
        }


        static void Main(string[] args)
        {
            Books book;
            book = new Books("Last Leaf", "O Henry", 56119846);
            Console.WriteLine(book);

            book = new Books("The Selfish Giant", "Oscar Wilde", 835348483);
            Console.WriteLine(book);
        }
        
    }
}
