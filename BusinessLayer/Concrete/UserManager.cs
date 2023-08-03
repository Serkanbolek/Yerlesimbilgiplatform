using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager: IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void DistrictAdd(User user)
        {
            _userDal.Insert(user);
        }

        public void DistrictDelete(User user)
        {
            throw new NotImplementedException();
        }

        public void DistrictUpdate(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetByID(int id)
        {
            var a = _userDal.List().ToList();
            var b = a.Where(x => x.UserID == id).ToList();
            return b;
        }

        public List<User> GetList(int id)
        {
            var a = _userDal.List().ToList();
            var b = a.Where(x =>x.StreetID == id).OrderByDescending(x=>x.Comments.CommentDate).ToList();
            return b;
        }
    }
}
