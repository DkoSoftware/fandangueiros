using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class ClassLessonsDAO : DaoBase<ClassLessonsEntity>
    {
         DsFandangueirosTableAdapters.ClassLessonsTableAdapter ta;

         public ClassLessonsDAO()
        {
            ta = new DsFandangueirosTableAdapters.ClassLessonsTableAdapter();
        }

         public override int Add(ClassLessonsEntity entity)
        {
            return ta.Insert(entity.IdClass
                           , entity.IdLessons);
        }

         public override int Update(ClassLessonsEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

            return ta.Update(entity.IdClass
                           , entity.IdLessons
                                           , originalEntity.Id
                                           , originalEntity.IdClass
                                           , originalEntity.IdLessons);
                    
        }

         public override int Delete(ClassLessonsEntity entity)
        {
            return ta.Delete( entity.Id
                            , entity.IdClass
                            , entity.IdLessons);
        }

         public override ClassLessonsEntity GetByID(int id)
        {
            return List.DataTableToList<ClassLessonsEntity>(ta.GetData()).FirstOrDefault(x => x.Id == id);
        }

         public List<ClassLessonsEntity> GetByIDLessons(int IdLessons)
         {
             return List.DataTableToList<ClassLessonsEntity>(ta.GetData()).Where(x => x.IdLessons == IdLessons).ToList();
         }

         public List<ClassLessonsEntity> GetByIDClass(int IdClass)
         {
             return List.DataTableToList<ClassLessonsEntity>(ta.GetData()).Where(x => x.IdClass == IdClass).ToList();
         }

         public override IQueryable<ClassLessonsEntity> GetAll()
        {
            return List.DataTableToList<ClassLessonsEntity>(ta.GetData()).AsQueryable();
        }
    }
}
