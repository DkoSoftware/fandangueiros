using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Entity
{
    public class ViewKnowledgeEntity : EntityBase
    {
        public string Type { get; set; }
        public string OtherObservation { get; set; }
        public int IdRegistrationForm { get; set; }
    }
}
