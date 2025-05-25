using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_IDF
{
    internal abstract class StrikeUnit
    {
        public abstract  string Name { set; get; }
        public int Capacity { set; get; }
        public  string EffectiveTarget { set; get; }
        public  int FualSupply { set; get; }

        public StrikeUnit(string name,int capacity,string effectivetarget)
        {
            Name = name;
            Capacity = capacity;
            EffectiveTarget = effectivetarget;

        }



    }
}
