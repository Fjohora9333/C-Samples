using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

//Fatima Tuj Johora, Section:1

namespace zisa_Dorm_Meal_Plan
{
    public class VM : INotifyPropertyChanged
    {
        #region Properties

        private BindingList<Dormitory> dorms;
        public BindingList<Dormitory> Dorms
        {
            get { return dorms; }
            set { dorms = value; NotifyChanged(); }
        }

        private BindingList<MealPlan> mealPlans;
        public BindingList<MealPlan> MealPlans
        {
            get { return mealPlans; }
            set { mealPlans = value; NotifyChanged(); }
        }
        //to show Dormcharge in the detail window
        private string dormcharge ;
        public string Dormcharge
        {
            get { return dormcharge; }
            set { dormcharge = value; NotifyChanged(); }
        }
        //to show Mealcharge in the detail window
        private string mealCharge;
        public string MealCharge
        {
            get { return mealCharge; }
            set { mealCharge = value; NotifyChanged(); }
        }

        private string totalCharge;
        public string TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; NotifyChanged(); }
        }

        private Dormitory selectedDorm;
        public Dormitory SelectedDorm
        {
            get { return selectedDorm; }
            set { selectedDorm = value; NotifyChanged(); }
        }

        private MealPlan selectedMealPlan;
        public MealPlan SelectedMealPlan
        {
            get { return selectedMealPlan; }
            set { selectedMealPlan = value; NotifyChanged(); }
        }

        public void CalculateTotalCharge()
        {
            TotalCharge= (SelectedDorm.DormCharge+ SelectedMealPlan.MealPlanCharge).ToString();
        }
        #endregion

        //constructor of VM
        public VM()
        {
            Dormitory DormAllen = new Dormitory("Allen", 1500);
            Dormitory DormPike = new Dormitory("Pike", 1600);
            Dormitory DormFarthing = new Dormitory("Farthing", 1800);
            Dormitory DoemUniversity = new Dormitory("University Suits", 2500);

            MealPlan OneWeekMeals = new MealPlan("7 meals per week ", 600);
            MealPlan TwoWeekMeals = new MealPlan("14 meals per week ", 1200);
            MealPlan UnlimitedMeals = new MealPlan("Unlimited meals ", 1700);

            Dorms = new BindingList<Dormitory>() { DormAllen, DormPike, DormFarthing, DoemUniversity };
            MealPlans = new BindingList<MealPlan>() { OneWeekMeals, TwoWeekMeals, UnlimitedMeals };

        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
