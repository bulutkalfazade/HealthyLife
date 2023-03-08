using DataAccess.Concrete;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntitityFramework
{
    public class EfUserDal : IUserDal
    {
       

        public void Add(User user)
        {
            using (HealthyLifeContext context = new HealthyLifeContext())
            {
                var addedEntity = context.Entry(user);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(User user)
        {
            using (HealthyLifeContext context = new HealthyLifeContext())
            {
                var deletedEntity = context.Entry(user);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            using (HealthyLifeContext context = new HealthyLifeContext())
            {
                return context.Set<User>().ToList();

            }
        }

    }
}
