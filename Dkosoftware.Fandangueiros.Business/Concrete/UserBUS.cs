using Dkosoftware.Fandangueiros.DAO.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class UserBUS : BusBase<UserEntity>
    {
        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type User</param>
        /// <returns>1 if ok  -1 if error</returns>
        public virtual int Add(UserEntity entity)
        {
            return new UserDAO().Add(entity);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type User</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(UserEntity entity)
        {
            return new UserDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type User</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(UserEntity entity)
        {
            return new UserDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type Teacher</returns>
        public UserEntity GetByID(int id)
        {
            return new UserDAO().GetByID(id);
        }

        public UserEntity GetByIdTeacher(int idTeacher)
        {
            return (from u in this.GetAll()
                    where u.IdTeacher.Equals(idTeacher)
                    select u).FirstOrDefault();
        }

        /// <summary>
        /// get list all registers in data base
        /// </summary>
        /// <returns>all registers of data base</returns>
        public List<UserEntity> GetAll()
        {
            return new UserDAO().GetAll().ToList();
        }
    }
}
