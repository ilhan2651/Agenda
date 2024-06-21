using Bussiness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class DairyManager : IDairyServices
    {
        IDairyDal _dairyDal;
       



        public DairyManager(IDairyDal dairyDal)
        {
            _dairyDal = dairyDal;
        }

        public void Add(Dairy dairy)
        {
            _dairyDal.Add(dairy);
        }

        public void Delete(Dairy dairy)
        {
            _dairyDal.Delete(dairy);

            
        }

        public List<Dairy> GetAll()
        {
            return _dairyDal.GetAll();
        }

        public Dairy GetOrderByDate(DateTime date)
        {
           return _dairyDal.Get(p=>p.DateTime==date);
        }

        public void Update(Dairy dairy)
        {
            _dairyDal.Update(dairy);
        }
    }
}
