using Dkosoftware.Fandangueiros.DAO.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class TeacherBUS : BusBase<TeacherEntity>
    {
        /// <summary>
        /// validate form fields
        /// </summary>
        /// <param name="entity">entity type Teacher</param>
        /// <returns>message error if error</returns>
        public string ValideteForm(TeacherEntity entity)
        {
            string message = string.Empty;
            if (string.IsNullOrEmpty(entity.Name))
                message = "Campo Nome em branco";            
            else if (string.IsNullOrEmpty(entity.Mobile) && string.IsNullOrEmpty(entity.Phone))
                message = "Obrigatório ao menos um número de telefone.";
            else if (string.IsNullOrEmpty(entity.Sex))
                message = "Selecione um sexo.";

            return message;
        }

        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type Teacher</param>
        /// <returns>1 if ok  -1 if error</returns>
        public virtual int Add(TeacherEntity entity)
        {
            return new TeacherDAO().Add(entity);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type Teacher</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(TeacherEntity entity)
        {
            return new TeacherDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type Teacher</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(TeacherEntity entity)
        {
            return new TeacherDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type Teacher</returns>
        public TeacherEntity GetByID(int id)
        {
            return  new TeacherDAO().GetByID(id);
        }

        /// <summary>
        /// get list all registers in data base
        /// </summary>
        /// <returns>all registers of data base</returns>
        public List<TeacherEntity> GetAll()
        {
            return new TeacherDAO().GetAll().ToList();
        }
    }
}
