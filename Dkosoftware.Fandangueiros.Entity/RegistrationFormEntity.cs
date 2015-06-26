using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Entity
{
    public class RegistrationFormEntity : EntityBase
    {
        public DateTime CreateDate { get; set; }
        public bool Payment { get; set; }
        public string Observation { get; set; }
        public int IdClass { get; set; }
        public int IdStudent { get; set; }
        public int IdRegistratinFormStudent { get; set; }
        public int IdRegistratinFormClass { get; set; }
    }
}
