using Dkosoftware.Fandangueiros.DAO.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class StudentBUS : BusBase<StudentEntity>
    {
        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type Student</param>
        /// <returns>idStudent added</returns>
        public virtual int Add(StudentEntity entity)
        {
            return new StudentDAO().Add(entity);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type Student</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(StudentEntity entity)
        {
            return new StudentDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type Student</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(StudentEntity entity)
        {
            return new StudentDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type Student</returns>
        public StudentEntity GetByID(int id)
        {
            return new StudentDAO().GetByID(id);
        }

        /// <summary>
        /// get list all registers in data base
        /// </summary>
        /// <returns>all registers of data base</returns>
        public List<StudentEntity> GetAll()
        {
            return new StudentDAO().GetAll().ToList();
        }
    }
}
