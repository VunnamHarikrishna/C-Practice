using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinee_Triner_Course
{
    public class Trinings
    {
        public int TriningID { get; set; }
        public string TringingName { get; set; }
        public string Trinerdata { get; set; }
        public string Coursedata { get; set; }

        private List<Trainee> TrineeData = new List<Trainee>();

        public void setTrineeData(Trainee Trineedata)
        {
            TrineeData.Add(Trineedata);

        }
        public List<Trainee> getTrineeData()
        {
            return TrineeData;
        }
    }
}