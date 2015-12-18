using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * 作者 ： 李科笠
             * 利用反射 + 抽象工厂进行数据访问,并且可以更改底层DB数据库。
             * 和前台代码彻底解耦合，如下，前台页面仅知道DataAccess类的CreateUser、CreateDepartment方法，并不需要知道具体创建的过程
             * 也不需要知道使用了那种数据库，若是更换了数据库（eg: Sqlserver => Oracle）,那么前台的代码不用更改，仅需在Web.config配置文件
             * 里面修改数据库类型即可
             */

            Model.User user = new Model.User();
            Service.IUser iu = Manager.DataAccess.CreateUser();
            iu.Insert(user); //给User表插入一条数据
            iu.GetUser(1);   //从User表根据ID获取一条记录

            Model.Department department = new Model.Department();
            Service.IDepartment idepartment = Manager.DataAccess.CreateDepartment();
            idepartment.Insert(department);
            idepartment.GetDepartment(1);
        }
    }
}