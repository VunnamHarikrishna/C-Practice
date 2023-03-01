using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinerTrinee
{
    public class Technology
    {
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public  List<Course> Cources = new List<Course>();
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
