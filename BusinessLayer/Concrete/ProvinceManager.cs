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
    public class ProvinceManager : IProvinceService
    {
        IProvinceDal _provinceDal;

        public ProvinceManager(IProvinceDal provinceDal)
        {
            _provinceDal = provinceDal;
        }

        public Province GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Province> GetList()
        {
            return _provinceDal.List().ToList();
        }

        public List<Province> GetListByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public void provinceAdd(Province province)
        {
            throw new NotImplementedException();
        }

        public void provinceDelete(Province province)
        {
            throw new NotImplementedException();
        }

        public void provinceUpdate(Province province)
        {
            throw new NotImplementedException();
        }
    }
}
