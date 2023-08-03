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
   
    public class NeighbourhoodManager : INeighbourhoodService
    {
        INeighbourhoodDal _neighbourhoodDal;

        public NeighbourhoodManager(INeighbourhoodDal neighbourhoodDal)
        {
            _neighbourhoodDal = neighbourhoodDal;
        }

        public Neighbourhood GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Neighbourhood> GetList(int ilceId)
        {
            var a = _neighbourhoodDal.List().ToList();
            return a.Where(x => x.DistrictID == ilceId).ToList();
        }

        public void NeighbourhoodAdd(Neighbourhood neighbourhood)
        {
            throw new NotImplementedException();
        }

        public void NeighbourhoodDelete(Neighbourhood neighbourhood)
        {
            throw new NotImplementedException();
        }

        public void NeighbourhoodUpdate(Neighbourhood neighbourhood)
        {
            throw new NotImplementedException();
        }
    }
}
