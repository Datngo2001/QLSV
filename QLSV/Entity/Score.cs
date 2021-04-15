using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Entity
{
    class Score
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public float StudentScore { get; set; }
        public string Description { get; set; }
    }
}
