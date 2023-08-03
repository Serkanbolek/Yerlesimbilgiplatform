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
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public void DistrictAdd(District district)
        {
            throw new NotImplementedException();
        }

        public void DistrictDelete(District district)
        {
            throw new NotImplementedException();
        }

        public void DistrictUpdate(District district)
        {
            throw new NotImplementedException();
        }

        public District GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<District> GetList(int cityId)
        {
           var a = _districtDal.List().Where(x => x.ilID == cityId).ToList();
           return a;
        }
    }
}
