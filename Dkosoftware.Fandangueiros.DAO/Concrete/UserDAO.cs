using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class UserDAO : DaoBase<UserEntity>
    {
        DsFandangueirosTableAdapters.UserTableAdapter ta;

        public UserDAO()
        {
            ta = new DsFandangueirosTableAdapters.UserTableAdapter();
        }

         public override int Add(UserEntity entity)
        {
            return ta.Insert(entity.IdTeacher
                           , entity.UserName
                           , entity.Password
                           , entity.AccessType
                           , entity.CreateDate);
        }

         public override int Update(UserEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

            return ta.Update(entity.IdTeacher
                           , entity.UserName
                           , entity.Password
                           , entity.AccessType
                           , entity.CreateDate
                                           , originalEntity.Id
                                           , originalEntity.IdTeacher
                                           , originalEntity.UserName
                                           , originalEntity.Password
                                           , originalEntity.AccessType
                                           , originalEntity.CreateDate);
                    
        }

         public override int Delete(UserEntity entity)
        {
            return ta.Delete( entity.Id
                            , entity.IdTeacher
                            , entity.UserName
                            , entity.Password
                            , entity.AccessType
                            , entity.CreateDate);
        }

         public override UserEntity GetByID(int id)
        {
            return List.DataTableToList<UserEntity>(ta.GetData()).FirstOrDefault(x => x.Id == id);
        }

         public override IQueryable<UserEntity> GetAll()
        {
            return List.DataTableToList<UserEntity>(ta.GetData()).AsQueryable();
        }
    }
}
