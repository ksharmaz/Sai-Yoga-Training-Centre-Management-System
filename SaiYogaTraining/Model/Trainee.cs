using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SaiYogaTraining.Model
{
    class Trainee : Connection
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public DateTime Date { get; set; }
        public string CourseID { get; set; }
        public Image Photo { get; set; }
    }
}
