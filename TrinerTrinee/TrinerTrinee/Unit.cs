using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinerTrinee
{
    public class Unit
    {
        public int UnitNo { get; set; }
        public string UnitName { get; set; }

        private List<Topic> Topics = new List<Topic>();

        public void SetTopics(Topic Topicobj)
        {
            Topics.Add(Topicobj);
        }
        public List<Topic> getTopic()
        {
            return Topics;
        }
    }
}
