using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class ViewKnowledgeDAO : DaoBase<ViewKnowledgeEntity>
    {
        DsFandangueirosTableAdapters.ViewKnowledgeTableAdapter ta;

        public ViewKnowledgeDAO()
        {
            ta = new DsFandangueirosTableAdapters.ViewKnowledgeTableAdapter();
        }

        public override int Add(ViewKnowledgeEntity entity)
        {
             ta.Insert(entity.Type
                      , entity.OtherObservation
                      ,entity.IdRegistrationForm);

             return GetAll().Max(x => x.Id);
        }

        public override int Update(ViewKnowledgeEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

           return ta.Update(entity.Type
                             ,entity.OtherObservation
                             ,entity.IdRegistrationForm
                                , originalEntity.Id
                                , originalEntity.Type
                                , originalEntity.OtherObservation
                                ,originalEntity.IdRegistrationForm);
        }

        public override int Delete(ViewKnowledgeEntity entity)
        {
          return  ta.Delete(entity.Id
                    , entity.Type
                    , entity.OtherObservation
                    ,entity.IdRegistrationForm);
        }

        public override ViewKnowledgeEntity GetByID(int id)
        {
            return List.DataTableToList<ViewKnowledgeEntity>(ta.GetData()).FirstOrDefault(x => x.Id == id);
        }

        public override IQueryable<ViewKnowledgeEntity> GetAll()
        {
            return List.DataTableToList<ViewKnowledgeEntity>(ta.GetData()).AsQueryable();
        }
    }
}
