using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Text;


namespace ado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            string cn=@"Data Source=DESKTOP-UE12GR7;Initial Catalog=xtlab;Integrated Security=True";
            using SqlConnection connect=new SqlConnection(cn);
            connect.Open();
            string sql="select * from Shippers";
            string sqlinssert="insert into Shippers(Hoten, Sodienthoai) values (@hoten, @sdt)";
            using DbCommand command=new SqlCommand();
            command.Connection=connect;
            command.CommandText=sqlinssert;
            var hoten=new SqlParameter("@hoten","");
            command.Parameters.Add(hoten);
            var sdt=new SqlParameter("@sdt", "");
            command.Parameters.Add(sdt);
            Console.Write("Nhập tên Shipper: ");
            Console.Write("Nhập số điện thoại: ");
            hoten.Value=Console.ReadLine();
            sdt.Value=Console.ReadLine();
            var kq= command.ExecuteNonQuery();
            Console.WriteLine("Insert success {0}", kq);
            command.CommandText=sql;
            var datareader=command.ExecuteReader();
            if(datareader.HasRows)
            {
                while(datareader.Read())
                {
                    Console.WriteLine($"Tên: {datareader["Hoten"]}, Số điện thoại: {datareader["SoDienThoai"]}");
                }
            }else{
                Console.WriteLine("no data");
            }

            // command.CommandText=sql;
            //Thêm parameter cách 1
            // var gia=new SqlParameter("@Gia", 20000);
            // command.Parameters.Add(gia);
            //Thêm para cách gọi hơn
            // var gia=command.Parameters.AddWithValue("@Gia", 20000);
            // using var datareader=command.ExecuteReader();
            // if (datareader.HasRows)
            // {
            //     while(datareader.Read())
            //     {
            //         var id=datareader["SanPhamID"];
                   
            //     }
            // }else{
            //     Console.WriteLine("Không có dữ liêu trả về");
            // }
            connect.Close();
         
        }
    }
}
