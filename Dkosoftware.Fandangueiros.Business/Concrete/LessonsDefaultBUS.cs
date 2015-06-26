using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dkosoftware.Fandangueiros.Entity;
using Dkosoftware.Fandangueiros.DAO.Concrete;

namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class LessonsDefaultBUS : BusBase<LessonsDefaultEntity>
    {
        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type LessonsDefault</param>
        /// <returns>1 if ok  -1 if error</returns>
        public virtual int Add(LessonsDefaultEntity entity)
        {
            return new LessonsDefaultDAO().Add(entity);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type LessonsDefault</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(LessonsDefaultEntity entity)
        {
            return new LessonsDefaultDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type LessonsDefault</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(LessonsDefaultEntity entity)
        {
            return new LessonsDefaultDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type LessonsDefault</returns>
        public LessonsDefaultEntity GetByID(int id)
        {
            return new LessonsDefaultDAO().GetByID(id);
        }

        /// <summary>
        /// get list all registers in data base
        /// </summary>
        /// <returns>all registers of data base</returns>
        public List<LessonsDefaultEntity> GetAll()
        {
            return new LessonsDefaultDAO().GetAll().ToList();
        }
    }
}
