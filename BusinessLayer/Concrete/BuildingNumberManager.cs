using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BuildingNumberManager : IBuildngNumberService
    {
        IBuildingNumberDal _buildingNumberDal;

        public BuildingNumberManager(IBuildingNumberDal buildingNumberDal)
        {
            _buildingNumberDal = buildingNumberDal;
        }

        public void BuildingNumberAdd(BuildingNumber street)
        {
            throw new NotImplementedException();
        }

        public void BuildingNumberDelete(BuildingNumber buildingNumber)
        {
            throw new NotImplementedException();
        }

        public void BuildingNumberUpdate(BuildingNumber buildingNumber)
        {
            throw new NotImplementedException();
        }

        public List<BuildingNumber> GetByID(int StreetID)
        {
            throw new NotImplementedException();
        }

        public List<BuildingNumber> GetList(int StreetID)
        {
            var a = _buildingNumberDal.List().ToList();
            var b = a.Where(x => x.StreetID == StreetID).ToList();
            return b;
        }
    }
}
