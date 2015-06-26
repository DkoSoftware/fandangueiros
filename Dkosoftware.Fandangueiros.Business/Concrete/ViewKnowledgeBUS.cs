using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DkoSoftware.Fandangueiros.DAO;
using Dkosoftware.Fandangueiros.DAO.Concrete;


namespace Dkosoftware.Fandangueiros.Business.Concrete
{
    public class ViewKnowledgeBUS : BusBase<ViewKnowledgeEntity>
    {
        /// <summary>
        /// add new register em data base
        /// </summary>
        /// <param name="entity">entity type Class</param>
        /// <returns>idClass added</returns>
        public virtual int Add(ViewKnowledgeEntity entity)
        {
            return new ViewKnowledgeDAO().Add(entity);
        }

        /// <summary>
        /// update exist register in data base
        /// </summary>
        /// <param name="entity">entity type class</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Update(ViewKnowledgeEntity entity)
        {
            return new ViewKnowledgeDAO().Update(entity);
        }

        /// <summary>
        /// delete register in data base
        /// </summary>
        /// <param name="entity">entity type Class</param>
        /// <returns> >0 if update successfull -1 if error</returns>
        public virtual int Delete(ViewKnowledgeEntity entity)
        {
            return new ViewKnowledgeDAO().Delete(entity);
        }

        /// <summary>
        /// get entity type teacher by id
        /// </summary>
        /// <param name="id">code number register of database</param>
        /// <returns>object data base type Class</returns>
        public ViewKnowledgeEntity GetByID(int id)
        {
            return new ViewKnowledgeDAO().GetByID(id);
        }

         /// <summary>
        /// get list all registers in data base
        /// </summary>
        /// <returns>all registers of data base</returns>
        public List<ViewKnowledgeEntity> GetAll()
        {
            return new ViewKnowledgeDAO().GetAll().ToList();
        }
    }
}
