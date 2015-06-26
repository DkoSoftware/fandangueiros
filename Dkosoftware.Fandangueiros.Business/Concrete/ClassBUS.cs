using Dkosoftware.Fandangueiros.DAO.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class ClassBUS : BusBase<ClassEntity>
    {
        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type Class</param>
        /// <returns>idClass added</returns>
        public virtual int Add(ClassEntity entity)
        {
            new ClassDAO().Add(entity);
            return new ClassBUS().GetAll().Max(x=> x.Id);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type class</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(ClassEntity entity)
        {
            return new ClassDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type Class</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(ClassEntity entity)
        {
            return new ClassDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type Class</returns>
        public ClassEntity GetByID(int id)
        {
            return new ClassDAO().GetByID(id);
        }

        public ClassEntity GetByIdLesson(int idLesson)
        {
            //return (from c in this.GetAll()
            //        join l in new LessonsDAO().GetAll() 
            //        on c.
            //        where u. IdTeacher.Equals(idTeacher)
            //        select u).FirstOrDefault();

            return null;
        }

        /// <summary>
        /// get list all registers in data base
        /// </summary>
        /// <returns>all registers of data base</returns>
        public List<ClassEntity> GetAll()
        {
            return new ClassDAO().GetAll().ToList();
        }
    }
}
