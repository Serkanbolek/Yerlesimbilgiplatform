using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IUserService
    {
        List<User> GetList(int id);
        void DistrictAdd(User user);
        List<User> GetByID(int id);
        void DistrictDelete(User user);
        void DistrictUpdate(User user);
    }
}
