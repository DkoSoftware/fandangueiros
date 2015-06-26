using Dkosoftware.Fandangueiros.Entity;
using DkoSoftware.Fandangueiros.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.DAO.Concrete
{
    public class RegistrationFormDAO : DaoBase<RegistrationFormEntity>
    {
        DsFandangueirosTableAdapters.RegistrationFormTableAdapter ta;
        DsFandangueirosTableAdapters.RegistrationFormClassTableAdapter taRegFormClass;
        DsFandangueirosTableAdapters.RegistrationFormStudentTableAdapter taRegFormStudent;

        public RegistrationFormDAO()
        {
            ta = new DsFandangueirosTableAdapters.RegistrationFormTableAdapter();
            taRegFormClass = new DsFandangueirosTableAdapters.RegistrationFormClassTableAdapter();
            taRegFormStudent = new DsFandangueirosTableAdapters.RegistrationFormStudentTableAdapter();
        }

        public int Add(RegistrationFormEntity entity,int idRegistrationParam)
        {
            int idRegistration = 0;
            if (idRegistrationParam <= 0)
            {
                ta.Insert(entity.CreateDate
                          , entity.Payment
                          , entity.Observation);

                idRegistration = List.DataTableToList<RegistrationFormEntity>(ta.GetData()).Max(x => x.Id);

                taRegFormClass.Insert(entity.IdClass, idRegistration);

                taRegFormStudent.Insert(entity.IdStudent, idRegistration);
            }
            else
            {
                taRegFormStudent.Insert(entity.IdStudent, idRegistrationParam);
            }

            return idRegistration;
        }

        public override int Update(RegistrationFormEntity entity)
        {
            var originalEntity = this.GetByID(entity.Id);

            //class
            taRegFormClass.Update(   entity.IdClass
                                   , entity.Id
                                   , originalEntity.IdRegistratinFormClass
                                   , originalEntity.IdClass,
                                     originalEntity.Id);
            //student
            taRegFormStudent.Update(entity.IdStudent
                                    ,entity.Id
                                    ,entity.IdRegistratinFormStudent
                                    ,entity.IdStudent
                                    ,entity.Id);

            //registration form
            return ta.Update(entity.CreateDate
                           , entity.Payment
                           , entity.Observation
                                           , originalEntity.Id
                                           , originalEntity.CreateDate
                                           , originalEntity.Payment);

        }

        public override int Delete(RegistrationFormEntity entity)
        {
            //class
            taRegFormClass.Delete(entity.IdRegistratinFormClass, entity.IdClass, entity.Id);
            
            //student
            taRegFormStudent.Delete(entity.IdRegistratinFormStudent, entity.IdStudent, entity.Id);

            //registration form
            return ta.Delete(entity.Id
                            , entity.CreateDate
                            , entity.Payment);
        }

        public override RegistrationFormEntity GetByID(int id)
        {
            var entity = (from r in ta.GetData().AsEnumerable()
                          join c in taRegFormClass.GetData().AsEnumerable() on (int)r["Id"] equals (int)c["IdRegistrationForm"]
                          join s in taRegFormStudent.GetData().ToList() on (int)r["Id"] equals (int)s["IdRegistrationForm"]
                          where (int)r["Id"] == id
                          select new RegistrationFormEntity
                          {
                              CreateDate = r.CreateDate,
                              Id = r.Id,
                              IdClass = c.IdClass,
                              IdStudent = s.IdStudent,
                              Observation = r.Observation,
                              Payment = r.Payment
                          }).FirstOrDefault();

            return entity;
        }

        public override IQueryable<RegistrationFormEntity> GetAll()
        {
            var listEntity = (from r in ta.GetData().AsEnumerable()
                          join c in taRegFormClass.GetData().AsEnumerable() on (int)r["Id"] equals (int)c["IdRegistrationForm"]
                          join s in taRegFormStudent.GetData().ToList() on (int)r["Id"] equals (int)s["IdRegistrationForm"]
                          select new RegistrationFormEntity
                          {
                              CreateDate = r.CreateDate,
                              Id = r.Id,
                              IdClass = c.IdClass,
                              IdStudent = s.IdStudent,
                              Observation = r.Observation,
                              Payment = r.Payment
                          }).ToList();

            return listEntity.AsQueryable();
        }
    }
}
