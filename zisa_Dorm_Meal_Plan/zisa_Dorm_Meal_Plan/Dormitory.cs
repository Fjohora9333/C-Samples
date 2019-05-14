using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fatima Tuj Johora, Section:1
namespace zisa_Dorm_Meal_Plan
{
    public class Dormitory
    {
        public string DormName { get; set; }
        public decimal DormCharge { get; set; }

        //Default Constructor
        public Dormitory()
        {
        }
        //Constructor with Teo parameters
        public Dormitory(string dormName, decimal dormCharge)
        {
            DormName = dormName;
            DormCharge = dormCharge;
        }
        public override string ToString() => $"DormName: {DormName}; DormCharge: {DormCharge}";

    }
}
