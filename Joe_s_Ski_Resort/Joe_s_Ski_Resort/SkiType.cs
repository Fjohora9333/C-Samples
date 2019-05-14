using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fatima Tuj Johora,Section:1
namespace Joe_s_Ski_Resort
{
    public class SkiType
    {
        public string SkiName { get; set; }
        public double SkiCharge { get; set; }

        //Default Constructor
        public SkiType()
        {
        }
        //Constructor with Two parameters
        public SkiType(string skiName, double skiCharge)
        {
            SkiName = skiName;
            SkiCharge = skiCharge;
        }
        public override string ToString() => $"SkiName: {SkiName}; SkiCharge {SkiCharge}";
    }
}
