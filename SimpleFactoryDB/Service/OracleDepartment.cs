using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Service
{
    public class OracleDepartment:IDepartment
    {
        public void Insert(Model.Department department)
        {
            Console.WriteLine("在 Oracle 中的Department表插入一条数据");
        }

        public Model.Department GetDepartment(int Id)
        {
            Console.WriteLine("在 Oracle 中的Department表通过Id读取一条数据");
            return null;
        }
    }
}