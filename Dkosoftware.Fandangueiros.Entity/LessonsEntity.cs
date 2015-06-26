using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Entity
{
    public class LessonsEntity : EntityBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime DateLesson { get; set; }
        public int Id { get; set; }
    }
}
