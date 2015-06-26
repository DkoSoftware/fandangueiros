using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class StudentDAO : DaoBase<StudentEntity>
    {
        DsFandangueirosTableAdapters.StudentTableAdapter ta;

        public StudentDAO()
        {
            ta = new DsFandangueirosTableAdapters.StudentTableAdapter();
        }

        public override int Add(StudentEntity entity)
        {
            ta.Insert(entity.Name
                    , entity.Phone
                    , entity.Mobile
                    , entity.Email
                    , entity.Adress
                    , entity.City
                    , entity.SexType);

            return GetAll().Max(x => x.Id);
        }

        public override int Update(StudentEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

            return ta.Update(entity.Name
                       , entity.Phone
                       , entity.Mobile
                       , entity.Email
                       , entity.Adress
                       , entity.City
                       , entity.SexType
                       , originalEntity.Id, originalEntity.Name
                                          , originalEntity.Phone
                                          , originalEntity.Mobile
                                          , originalEntity.Email
                                          , originalEntity.Adress
                                          , originalEntity.City
                                          , originalEntity.SexType);

        }

        public override int Delete(StudentEntity entity)
        {
            return ta.Delete(entity.Id
                      , entity.Name
                      , entity.Phone
                      , entity.Mobile
                      , entity.Email
                      , entity.Adress
                      , entity.City
                      , entity.SexType);
        }

        public override StudentEntity GetByID(int id)
        {
            return List.DataTableToList<StudentEntity>(ta.GetData()).FirstOrDefault(x => x.Id == id);
        }

        public override IQueryable<StudentEntity> GetAll()
        {
            return List.DataTableToList<StudentEntity>(ta.GetData()).AsQueryable();
        }
    }
}
