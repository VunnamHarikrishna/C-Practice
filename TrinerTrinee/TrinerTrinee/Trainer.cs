using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinerTrinee
{
    public class Trainer
    {
        public int TrinerID { get; set; }
        public string TrinerName { get; set; }

        private List<Trainee> trainees = new List<Trainee>();

        private List<Trinings> trininglist = new List<Trinings>();

        public void settrinees(Trainee trineedata)
        {
            trainees.Add(trineedata);
        }
        public List<Trainee> GetTrinees()
        {
            return trainees;
        }
        public void settrininglist(Trinings Triningdata)
        {
            trininglist.Add(Triningdata);

        }
        public List<Trinings> GetTrinings()
        {
            return trininglist;
        }
    }

}
