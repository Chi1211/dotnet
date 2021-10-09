using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex1
{
    class Student{

        public int Id{
            get;
            set;
        }
        public string Name{ get; set;}
        public string Address{ get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            IList<String> names=new List<String>();
            for(int i=0;i<5;i++)
            {
                Console.Write("Bạn nhập: ");
                names.Add(Console.ReadLine());
            }
            var query= from name in names 
                        where name.Contains("a")
                        select name;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
