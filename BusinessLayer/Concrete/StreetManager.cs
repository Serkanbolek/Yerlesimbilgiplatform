using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
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
    public class StreetManager : IStreetService
        
    {
        IStreetDal _streetService;

        public StreetManager(IStreetDal streetService)
        {
            _streetService = streetService;
        }
        public List<Street> GetList(int NeighbourhoodID)
        {
            var a = _streetService.List().ToList();
            var b = a.Where(x => x.NeighbourhoodID == NeighbourhoodID).ToList();
            return b;
        }

        public void StreetAdd(Street street)
        {
            throw new NotImplementedException();
        }

        public void StreetDelete(Street street)
        {
            throw new NotImplementedException();
        }

        public void StreetUpdate(Street street)
        {
            throw new NotImplementedException();
        }

        List<Street> IStreetService.GetByID(int NeighbourhoodID)
        {
            var a = _streetService.List().ToList();
            var b = a.Where(x => x.NeighbourhoodID == NeighbourhoodID).ToList();
            return b;
        }
    }
}
