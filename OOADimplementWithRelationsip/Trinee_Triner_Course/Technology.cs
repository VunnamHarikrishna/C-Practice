using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinee_Triner_Course
{
   public class Technology
    {
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public  List<Course> Cources { get; set; }
        public void SetCources(Course coursedata)
        {
            Cources.Add(coursedata);

        }
        public List<Course> GetCourses()
        {
            return Cources;
        }
    }
}
