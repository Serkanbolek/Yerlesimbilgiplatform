using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INeighbourhoodService
    {
        List<Neighbourhood> GetList(int ilceId);
        void NeighbourhoodAdd(Neighbourhood neighbourhood);
        Neighbourhood GetByID(int id);
        void NeighbourhoodDelete(Neighbourhood neighbourhood);
        void NeighbourhoodUpdate(Neighbourhood neighbourhood);
    }
}
