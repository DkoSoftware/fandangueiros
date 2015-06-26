using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Entity
{
    public class UserEntity : EntityBase
    {
        public int IdTeacher { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccessType { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
