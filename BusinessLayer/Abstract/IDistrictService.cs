using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDistrictService
    {
        List<District> GetList(int cityId);
        void DistrictAdd(District district);
        District GetByID(int id);
        void DistrictDelete(District district);
        void DistrictUpdate(District district);
    }
}
