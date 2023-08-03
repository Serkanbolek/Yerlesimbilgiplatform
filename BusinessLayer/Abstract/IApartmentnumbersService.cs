using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IApartmentnumbersService
    {
        List<Apartmentnumber> GetList(int ApartmentnumberID);
        void ApartmentnumberAdd(Apartmentnumber ApartmentnumberID);
        List<Apartmentnumber> GetByID(int ApartmentnumberID);
        void ApartmentnumberDelete(Apartmentnumber apartmentnumber);
        void ApartmentnumberUpdate(Apartmentnumber apartmentnumber);
    }
}
