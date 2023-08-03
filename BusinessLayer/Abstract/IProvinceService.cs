using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProvinceService
    { 
        List<Province> GetList();
        void provinceAdd(Province province);
        Province GetByID(int id);
        void provinceDelete(Province province);
        void provinceUpdate(Province province);
    }
}
