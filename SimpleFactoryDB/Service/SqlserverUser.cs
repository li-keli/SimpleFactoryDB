using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Service
{
    //Sqlserver操作类
    public class SqlserverUser : IUser
    {
        public void Insert(Model.User user)
        {
            Console.WriteLine("在 Sqlserver 中给User表添加一条记录");
        }

        public Model.User GetUser(int Id)
        {
            Console.WriteLine("在 Sqlserver 中根据Id得到User表的一条记录");
            return null;
        }
    }
}