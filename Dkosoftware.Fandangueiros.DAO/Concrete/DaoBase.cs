using Dkosoftware.Fandangueiros.DAO.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class DaoBase<T> : IDao<T> where T : Dkosoftware.Fandangueiros.Entity.EntityBase
    {
        public DsFandangueiros dsContext;

        public DaoBase()
        {
            dsContext = new DsFandangueiros();
        }

        public virtual int Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual int Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
