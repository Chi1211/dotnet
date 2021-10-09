using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

using System.Text;

namespace adapter
{
    class Program
    {
        public static void showDataTable(DataTable table)
        {
            Console.WriteLine("Tên bảng: {0}", table.TableName);
            foreach(DataColumn col in table.Columns)
            {
                
                Console.Write($"{col.ColumnName, 10}");
            }
            Console.WriteLine();
            foreach(DataRow row in table.Rows)
            {
                for(int i=0; i<table.Columns.Count;i++)
                {
                    Console.Write($"{row[i], 10}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            string cn=$"Data Source=DESKTOP-UE12GR7;Initial Catalog=xtlab;Integrated Security=True";
            using SqlConnection connection=new SqlConnection(cn);
            connection.Open();
            var adapter= new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Shippers");
            // Select
            string sqlselect="select * from Shippers";
            adapter.SelectCommand=new SqlCommand(sqlselect, connection);

            // insert
            // string sqlinsert=" insert into Shippers(Hoten, Sodienthoai) values (@hoten, @sdt)";
            // adapter.InsertCommand=new SqlCommand(sqlinsert, connection);
            // adapter.InsertCommand.Parameters.Add("@hoten", SqlDbType.NVarChar, 255, "Hoten");
            // adapter.InsertCommand.Parameters.Add("@Sdt", SqlDbType.NVarChar, 255, "Sodienthoai");

            // delete

            string sqldel="delete from Shippers where ShipperID=@shipperid";
            adapter.DeleteCommand=new SqlCommand(sqldel, connection);
            var del=adapter.DeleteCommand.Parameters.Add("@shipperid", SqlDbType.Int);
            del.SourceColumn="ShipperID";
            del.SourceVersion=DataRowVersion.Original;


            var dataset=new DataSet();
            adapter.Fill(dataset);
            DataTable table=dataset.Tables["Shippers"];
            showDataTable(table);
            var row=table.Rows[3];
            row.Delete();
            // row["ShipperID"]=4;
            // row["Hoten"]="Chi";
            // row["Sodienthoai"]="05789";
            adapter.Update(dataset);
            connection.Close();
            
        }
    }
}
