using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fatima Tuj Johora,Section:1

namespace Joe_s_Ski_Resort
{
    public class FuelType
    {
        public string FuelTypeName { get; set; }
        public double FuelCharge { get; set; }

        //Default Constructor
        public FuelType()
        {
        }
        //Constructor with Two parameters
        public FuelType(string fuelTypeName, double fuelCharge)
        {
            FuelTypeName = fuelTypeName;
            FuelCharge = fuelCharge;
        }
        public override string ToString() => $"FuelTypeName: {FuelTypeName}; FuelCharge {FuelCharge}";
    }
}
