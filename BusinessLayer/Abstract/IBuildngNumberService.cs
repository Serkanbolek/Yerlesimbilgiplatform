using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBuildngNumberService
    {
        List<BuildingNumber> GetList(int StreetID);
        void BuildingNumberAdd(BuildingNumber street);
        List<BuildingNumber> GetByID(int StreetID);
        void BuildingNumberDelete(BuildingNumber buildingNumber);
        void BuildingNumberUpdate(BuildingNumber buildingNumber);
    }
}
