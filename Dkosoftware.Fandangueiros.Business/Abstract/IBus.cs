using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Business.Abstract
{
    public interface IBus<T> where T : Dkosoftware.Fandangueiros.Entity.EntityBase
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        T GetByID(int id);
        IQueryable<T> GetAll();
    }
}
