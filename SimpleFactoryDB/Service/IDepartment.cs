using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication5.Service
{
    public interface IDepartment
    {
        void Insert(Model.Department department);

        Model.Department GetDepartment(int Id);
    }
}
