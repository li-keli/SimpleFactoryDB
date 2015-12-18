using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication5.Service
{
    public interface IUser
    {
        void Insert(Model.User user);

        Model.User GetUser(int Id);
    }
}
