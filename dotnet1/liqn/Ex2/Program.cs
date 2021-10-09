using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    class Program
    {
        class Student{

        public int Id{
            get;
            set;
        }
        public string Name{ get; set;}
        public string Address{ get; set;}
    }
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            IList<Student> list=new List<Student>();
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Nhập sinh viên thứ: {0}", i+1);
                Console.Write("Nhập tên: ");
                string name=Console.ReadLine();
                Console.Write("\nNhập địa chỉ: ");
                string address=Console.ReadLine();
                Student st=new Student();
                st.Id=i+1;
                st.Name=name;
                st.Address=address;
                list.Add(st);
            }

            var arrays= list.Where(s=> s.Name.Contains("u"));
            foreach(var array in arrays)
            {
                Console.WriteLine(array.Name);
            }
        }
    }
}
