using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dkosoftware.Fandangueiros.Entity
{
    public class ClassEntity : EntityBase
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal ValueCourse { get; set; }
        public string Local { get; set; }
        public List<LessonsEntity> ListLessons{ get; set; }
        public string  Type { get; set; }
    }
}
