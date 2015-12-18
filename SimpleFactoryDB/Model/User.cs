using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Model
{
    //用户表
    public class User
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}