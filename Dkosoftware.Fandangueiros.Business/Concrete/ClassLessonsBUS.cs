using Dkosoftware.Fandangueiros.DAO.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class ClassLessonsBUS : BusBase<ClassLessonsEntity>
    {
        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type ClassLessons</param>
        /// <returns>1 if ok  -1 if error</returns>
        public virtual int Add(ClassLessonsEntity entity)
        {
            return new ClassLessonsDAO().Add(entity);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type ClassLessons</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(ClassLessonsEntity entity)
        {
            return new ClassLessonsDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type ClassLessons</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(ClassLessonsEntity entity)
        {
            return new ClassLessonsDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type ClassLessons</returns>
        public ClassLessonsEntity GetByID(int id)
        {
            return new ClassLessonsDAO().GetByID(id);
        }

        /// <summary>
        /// get entity type ClassLessons by idLessons
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type list ClassLessons</returns>
        public List<ClassLessonsEntity> GetByIDLessons(int idLessons)
        {
            return new ClassLessonsDAO().GetByIDLessons(idLessons);
        }

        /// <summary>
        /// get entity type ClassLessons by idClass
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type list ClassLessons</returns>
        public List<ClassLessonsEntity> GetByIDClass(int idClass)
        {
            return new ClassLessonsDAO().GetByIDClass(idClass);
        }

        /// <summary>
        /// get list all registers in data base
        /// </summary>
        /// <returns>all registers of data base</returns>
        public List<ClassLessonsEntity> GetAll()
        {
            return new ClassLessonsDAO().GetAll().ToList();
        }
    }
}
