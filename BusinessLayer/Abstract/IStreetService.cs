using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStreetService
    {
        List<Street> GetList(int NeighbourhoodID);
        void StreetAdd(Street street);
        List<Street> GetByID(int NeighbourhoodID);
        void StreetDelete(Street street);
        void StreetUpdate(Street street);
    }
}
