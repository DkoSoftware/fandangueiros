using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class TeacherDAO : DaoBase<TeacherEntity>
    {
        DsFandangueirosTableAdapters.TeacherTableAdapter ta;

        public TeacherDAO()
        {
            ta = new DsFandangueirosTableAdapters.TeacherTableAdapter();
            ta.Adapter.AcceptChangesDuringFill = true;
            ta.Adapter.AcceptChangesDuringUpdate = true;
        }

        public override int Add(TeacherEntity entity)
        {
            var result = ta.Insert(entity.Name
                            , entity.Sex
                           , entity.Mobile
                           , entity.Phone);

            return result;
        }

        public override int Update(TeacherEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

            return ta.Update(entity.Name
                            , entity.Sex
                            , entity.Mobile
                           , entity.Phone

                                           , originalEntity.Id
                                           , originalEntity.Name
                                           , originalEntity.Sex
                                           , originalEntity.Mobile
                                           , originalEntity.Phone);

        }

        public override int Delete(TeacherEntity entity)
        {
            return ta.Delete(entity.Id
                            , entity.Name
                            , entity.Sex
                            , entity.Mobile
                            , entity.Phone);
        }

        public override TeacherEntity GetByID(int id)
        {
            return List.DataTableToList<TeacherEntity>(ta.GetData()).FirstOrDefault(x => x.Id == id);
        }

        public override IQueryable<TeacherEntity> GetAll()
        {
            var list = ta.GetData();
            return List.DataTableToList<TeacherEntity>(ta.GetData()).AsQueryable();
        }
    }
}
