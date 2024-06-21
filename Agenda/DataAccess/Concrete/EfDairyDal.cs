using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfDairyDal : IDairyDal
    {
        public void Add(Dairy entity)
        {
            using (DairyContext context = new DairyContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Dairy entity)
        {
            using (DairyContext context = new DairyContext())
            {
                if (entity!=null)
                {
                 var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("No record found for the given date.");
                }
               
            }
        }

        public Dairy Get(Expression<Func<Dairy, bool>> filter = null )
        {
            using (DairyContext context = new DairyContext())
            {
                return context.Set<Dairy>().SingleOrDefault(filter);
            }
        }

        public List<Dairy> GetAll(Expression<Func<Dairy, bool>> filter = null)
        {
            using (DairyContext context = new DairyContext())
            {
                return filter == null
                    ? context.Set<Dairy>().OrderByDescending(d=>d.DateTime).ToList()
                    : context.Set<Dairy>().Where(filter).ToList();


            }
        }

        public void Update(Dairy entity)
        {
            using (DairyContext context = new DairyContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
