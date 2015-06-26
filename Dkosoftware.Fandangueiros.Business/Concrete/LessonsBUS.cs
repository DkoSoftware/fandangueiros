using Dkosoftware.Fandangueiros.DAO.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class LessonsBUS : BusBase<LessonsEntity>
    {
        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type Lessons</param>
        /// <returns>1 if ok  -1 if error</returns>
        public virtual int Add(LessonsEntity entity)
        {
            return new LessonsDAO().Add(entity);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type Lessons</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(LessonsEntity entity)
        {
            return new LessonsDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type Lessons</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(LessonsEntity entity)
        {
            return new LessonsDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type Lessons</returns>
        public LessonsEntity GetByID(int id)
        {
            return new LessonsDAO().GetByID(id);
        }

        /// <summary>
        /// get list all registers in data base
        /// </summary>
        /// <returns>all registers of data base</returns>
        public List<LessonsEntity> GetAll()
        {
            return new LessonsDAO().GetAll().ToList();
        }
    }
}
