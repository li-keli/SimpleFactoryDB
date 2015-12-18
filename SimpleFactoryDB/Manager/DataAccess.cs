using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Reflection;

namespace WebApplication5.Manager
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "WebApplication5";
        private static readonly string db = ConfigurationManager.AppSettings["db"];

        public static Service.IUser CreateUser()
        {
            string ClassName = AssemblyName + "." + db + "User";
            return (Service.IUser)Assembly.Load(AssemblyName).CreateInstance(ClassName);
        }

        public static Service.IDepartment CreateDepartment()
        {
            string ClassName = AssemblyName + "." + db + "Department";
            return (Service.IDepartment)Assembly.Load(AssemblyName).CreateInstance(ClassName);
        }
    }
}