using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinerTrinee
{
    public class Module
    {
        public string ModuleName { get; set; }

        private List<Unit> Units = new List<Unit>();

        public void setUnits(Unit UnitData)
        {
            Units.Add(UnitData);
        }
        public List<Unit> getUnits()
        {
            return Units;
        }
    }
}
