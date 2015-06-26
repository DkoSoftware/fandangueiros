using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class LessonsDAO : DaoBase<LessonsEntity>
    {
        DsFandangueirosTableAdapters.LessonsTableAdapter ta;

        public LessonsDAO()
        {
            ta = new DsFandangueirosTableAdapters.LessonsTableAdapter();
        }

        public override int Add(LessonsEntity entity)
        {
            return ta.Insert(entity.Name
                ,entity.Type
                           , entity.DateLesson);
        }

        public override int Update(LessonsEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

            return ta.Update(entity.Name
                             , entity.Type
                            , entity.DateLesson
                                            , originalEntity.Id
                                            , originalEntity.Name
                                            , originalEntity.Type
                                            , originalEntity.DateLesson);
                    
        }

        public override int Delete(LessonsEntity entity)
        {
            return ta.Delete(  entity.Id
                             , entity.Name
                             , entity.Type
                             , entity.DateLesson);
        }

        public override LessonsEntity GetByID(int id)
        {
            return List.DataTableToList<LessonsEntity>(ta.GetData()).FirstOrDefault(x => x.Id == id);
        }

        public override IQueryable<LessonsEntity> GetAll()
        {
            return List.DataTableToList<LessonsEntity>(ta.GetData()).AsQueryable();
        }
    }
}
