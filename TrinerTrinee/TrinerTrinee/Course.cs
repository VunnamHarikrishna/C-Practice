using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinerTrinee
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Technology { get; set; }

        private List<Module> Modulelist = new List<Module>();

        public void setModulelist(Module moduledata)
        {
            Modulelist.Add(moduledata);
        }
        public List<Module> getModulelist()
        {
            return Modulelist;
        }

    }
}
