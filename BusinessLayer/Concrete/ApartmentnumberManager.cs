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
    public class ApartmentnumberManager : IApartmentnumbersService
    {
        IApartmentnumberDal _apartmentnumbersDal;

        public ApartmentnumberManager(IApartmentnumberDal apartmentnumbersDal)
        {
            _apartmentnumbersDal = apartmentnumbersDal;
        }

        public void ApartmentnumberAdd(Apartmentnumber ApartmentnumberID)
        {
            throw new NotImplementedException();
        }

        public void ApartmentnumberDelete(Apartmentnumber apartmentnumber)
        {
            throw new NotImplementedException();
        }

        public void ApartmentnumberUpdate(Apartmentnumber apartmentnumber)
        {
            throw new NotImplementedException();
        }

        public List<Apartmentnumber> GetByID(int ApartmentnumberID)
        {
            throw new NotImplementedException();
        }

        public List<Apartmentnumber> GetList(int ApartmentnumberID)
        {
            var a = _apartmentnumbersDal.List().ToList();
            var b = a.Where(x => x.BuildingNumberID == ApartmentnumberID).ToList();
            return b;
        }
    }
}
