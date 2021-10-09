using System;

namespace Ex3
{
    class Program
    {
        class Student{
            public int Id{get; set;}
            public string name{get;set;}
            
        }
        delegate bool IsTeenAge(Student s);
        static void Main(string[] args)
        {
           IsTeenAge isteen=s=>s.Id==3;
           Student st=new Student();
           st.Id=2;
           Console.Write(isteen(st));
        }
    }
}
