using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IDairyServices
    {
        Dairy GetOrderByDate(DateTime date);

        List<Dairy> GetAll();

        void Add(Dairy dairy);
        void Delete(Dairy dairy);
        void Update(Dairy dairy);


    }
}
