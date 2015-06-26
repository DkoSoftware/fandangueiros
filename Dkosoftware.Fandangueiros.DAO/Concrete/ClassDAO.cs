using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class ClassDAO : DaoBase<ClassEntity>
    {
        DsFandangueirosTableAdapters.ClassTableAdapter ta;

        public ClassDAO()
        {
            ta = new DsFandangueirosTableAdapters.ClassTableAdapter();
        }

        public override int Add(ClassEntity entity)
        {
          return  ta.Insert(entity.Name
                    , entity.StartDate
                    , entity.FinishDate
                    , entity.ValueCourse
                    , entity.Local
                    ,entity.Type);

            // add lesson of class
           foreach (LessonsEntity lesson in entity.ListLessons)
          {
          }

        }

        public override int Update(ClassEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

           return ta.Update(entity.Name
                             ,entity.StartDate
                            , entity.FinishDate
                            , entity.ValueCourse
                            , entity.Local
                            ,entity.Type
                                , originalEntity.Id
                                , originalEntity.Name
                                , originalEntity.StartDate
                                , originalEntity.FinishDate
                                , originalEntity.ValueCourse
                                , originalEntity.Type);
                    
        }

        public override int Delete(ClassEntity entity)
        {
          return  ta.Delete(entity.Id
                    , entity.Name
                    , entity.StartDate
                    , entity.FinishDate
                    , entity.ValueCourse
                    ,entity.Type);
        }

        public override ClassEntity GetByID(int id)
        {
            return List.DataTableToList<ClassEntity>(ta.GetData()).FirstOrDefault(x => x.Id == id);
        }

        public override IQueryable<ClassEntity> GetAll()
        {
            return List.DataTableToList<ClassEntity>(ta.GetData()).AsQueryable();
        }
    }
}
