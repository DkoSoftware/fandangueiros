using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class LessonsDefaultDAO : DaoBase<LessonsDefaultEntity>
    {
        DsFandangueirosTableAdapters.LessonsDefaultTableAdapter ta;

        public LessonsDefaultDAO()
        {
            ta = new DsFandangueirosTableAdapters.LessonsDefaultTableAdapter();
        }

        public override int Add(LessonsDefaultEntity entity)
        {
          return  ta.Insert(entity.NameLessonDefault
                          , entity.Type);

        }

        public override int Update(LessonsDefaultEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

           return ta.Update(entity.NameLessonDefault
                          , entity.Type
                                , originalEntity.Id
                                , originalEntity.NameLessonDefault
                                , originalEntity.Type);
                    
        }

        public override int Delete(LessonsDefaultEntity entity)
        {
          return  ta.Delete(entity.Id
                            , entity.NameLessonDefault
                            , entity.Type);
        }

        public override LessonsDefaultEntity GetByID(int id)
        {
            return List.DataTableToList<LessonsDefaultEntity>(ta.GetData()).FirstOrDefault(x => x.Id == id);
        }

        public override IQueryable<LessonsDefaultEntity> GetAll()
        {
            return List.DataTableToList<LessonsDefaultEntity>(ta.GetData()).AsQueryable();
        }
    }
}
