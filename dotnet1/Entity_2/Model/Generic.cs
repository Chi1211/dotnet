using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Entity_2{
    public class Generic{
        public static void CreatedDatabase(){
            using var dbcontext= new ShopDBContext();
            string dbname=dbcontext.Database.GetDbConnection().Database;
            var result=dbcontext.Database.EnsureCreated();
            if(result)
            {
                Console.WriteLine($"{dbname} db Created");
            }else{
                Console.WriteLine($"{dbname} db not create");
            }
        }
        public static void DropDatabase(){
            using var dbcontext=new ShopDBContext();
            string dbname=dbcontext.Database.GetDbConnection().Database;
            var result=dbcontext.Database.EnsureDeleted();
            if(result)
            {
                Console.WriteLine($"{dbname} delete successed");
            }else{
                Console.WriteLine($"{dbname} delete no successed");
            }
        }
        
    }
}