using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fatima Tuj Johora, Section:1
namespace zisa_Dorm_Meal_Plan
{
    public class MealPlan
    {
        public string MealPlanName { get; set; }
        public decimal MealPlanCharge { get; set; }

        //Default Constructor
        public MealPlan()
        {
        }
        //Constructor with Teo parameters

        public MealPlan(string mealPlanName, decimal mealPlanCharge)
        {
            MealPlanName = mealPlanName;
            MealPlanCharge = mealPlanCharge;
        }
        public override string ToString() => $"MealPlanName: {MealPlanName}; MealPlanCharge: {MealPlanCharge}";

    }
}
