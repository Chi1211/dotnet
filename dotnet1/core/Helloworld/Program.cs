using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Helloworld
{
class Program {
      static void Main(string[] args) {
         // #region 
         // FileStream fs=new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
         // for(int i=0;i<20;i++)
         // {
         //    fs.WriteByte((byte)i);
         // }

         // fs.Position=0;
         // for(int i=0;i<20;i++)
         // {
         //    Console.Write(fs.ReadByte()+" ");
         // }
         // fs.Close();
         // #endregion
         // Regex re=new Regex(@"\d");
         // Match rs=re.Match("bichchi.1232");
         // while(rs!=Match.Empty)
         // {
         //    Console.Write(rs.ToString());
         //    rs=rs.NextMatch();
         // }
         int a=4;
         int b=a;
         Console.WriteLine("a:{0}, b:{1}", a,b);
         b=2;
         Console.WriteLine("a:{0}, b:{1}", a,b);
      }

   }

   // class Demo{
   //    // Console.Write("Demo");
   // }
}

