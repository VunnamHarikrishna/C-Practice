using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinee_Triner_Course
{
   public class Trainee
    {
        public int TraineeID { get; set; }
        public string TrineeName { get; set; }

        public string TrinerName { get; set; }

        private List<Trinings> Trinings = new List<Trinings>();

        public void TriningsAdd(Trinings str)
        {
            Trinings.Add(str);
        }
        public List<Trinings> GetTrinings()
        {
            return Trinings;
        }
    }
}
