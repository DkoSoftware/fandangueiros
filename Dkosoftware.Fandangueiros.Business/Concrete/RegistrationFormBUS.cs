using Dkosoftware.Fandangueiros.DAO.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class RegistrationFormBUS : BusBase<RegistrationFormEntity>
    {
        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type Registration Form include class and student FK</param>
        /// <returns>idClass added</returns>
        public virtual int Add(RegistrationFormEntity entity, int idReg)
        {
            return new RegistrationFormDAO().Add(entity,idReg);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type Registration Form include class and student FK</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(RegistrationFormEntity entity)
        {
            return new RegistrationFormDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type Registration Form include class and student FK</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(RegistrationFormEntity entity)
        {
            return new RegistrationFormDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type Registration Form include class and student FK</returns>
        public RegistrationFormEntity GetByID(int id)
        {
            return new RegistrationFormDAO().GetByID(id);
        }

        public RegistrationFormEntity GetByIdLesson(int idLesson)
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
        public List<RegistrationFormEntity> GetAll()
        {
            return new RegistrationFormDAO().GetAll().ToList();
        }
    }
}
