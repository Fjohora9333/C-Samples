using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zisa_work_shop_selector
{
    class VM: INotifyPropertyChanged
    {
        #region definitions
        //define values used for interaction with XAML sheet. Includes textboxes for input,  indexs of combo box, and labels for output
        private int workshopIndex = -1;
        public int WorkshopIndex
        {
            get { return workshopIndex; }
            set { workshopIndex = value; CalculateTotal(); NotifyChanged(); }
        }

        private int locationIndex = -1;
        public int LocationIndex
        {
            get { return locationIndex; }
            set { locationIndex = value; CalculateTotal(); NotifyChanged(); }
        }

        private string inputName = "";
        public string InputName
        {
            get { return inputName; }
            set { inputName = value; CalculateTotal(); NotifyChanged(); }
        }

        private string selectedLabel = "";
        public string SelectedLabel
        {
            get { return selectedLabel; }
            set { selectedLabel = value; NotifyChanged(); }
        }

        private string workshopCostValueLabel = "";
        public string WorkshopCostValueLabel
        {
            get { return workshopCostValueLabel; }
            set { workshopCostValueLabel = value; NotifyChanged(); }
        }

        private string locationCostValueLabel = "";
        public string LocationCostValueLabel
        {
            get { return locationCostValueLabel; }
            set { locationCostValueLabel = value; NotifyChanged(); }
        }

        private string discountLabel = "";
        public string DiscountLabel
        {
            get { return discountLabel; }
            set { discountLabel = value; NotifyChanged(); }
        }

        private string discountValueLabel = "";
        public string DiscountValueLabel
        {
            get { return discountValueLabel; }
            set { discountValueLabel = value; NotifyChanged(); }
        }

        private string totalCostValueLabel = "";
        public string TotalCostValueLabel
        {
            get { return totalCostValueLabel; }
            set { totalCostValueLabel = value; NotifyChanged(); }
        }
        #endregion
        #region Logic
        public void CalculateTotal()
        {
            if(WorkshopIndex>0 && LocationIndex > 0)
            {
                string[] WORKSHOP_NAME = { "Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview" };
                int[] WORKSHOP_DAYS = { 3, 3, 3, 5, 1 };
                decimal [] WORKSHOP_COST = { 1000, 800, 1500, 1300, 500 };
                string[] LOCATION_NAME = { "Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh" };
                decimal[] LOCATION_COST = { 150, 225, 175, 300, 175, 150 };
                char[] DISCOUNT_CHARACTERS = { 'A', 'F', 'J', 'N', 'S' };
                const char FAIL_LETTER = 'K';
                const decimal NAME_DISCOUNT = (decimal)0.1;

                string selectedWorkshopName = WORKSHOP_NAME[workshopIndex];
                int selectedWorkshopDays = WORKSHOP_DAYS[workshopIndex];
                decimal selectedWorkshopCost = WORKSHOP_COST[workshopIndex];
                string selectedLocationName = LOCATION_NAME[locationIndex];
                decimal selectedLocationCost = LOCATION_COST[locationIndex];
                decimal nameDiscount = 0;
                string nameDiscountString = "0%";
                //Check first character of text input, apply additional discount if first character in character list
                char firstCharName = inputName.Length > 0 == true ? inputName[0] : FAIL_LETTER;
                if (DISCOUNT_CHARACTERS.Contains(firstCharName))
                {
                    nameDiscount = NAME_DISCOUNT;
                    nameDiscountString = $"Your name starts with the letter {firstCharName}! Discount {100 * nameDiscount}% registration:";
                }
                else
                {
                    nameDiscount = 0;
                    nameDiscountString = $"Discount 0%:";
                }

                //Calculate totals to display, and assign values to labels in XAML
                decimal totalLocationCost = selectedWorkshopDays * selectedLocationCost;
                decimal registrationDiscount = selectedWorkshopCost * nameDiscount;
                decimal totalWorkshopCost = selectedWorkshopCost + totalLocationCost - registrationDiscount;
                SelectedLabel = $"You have selected the {selectedWorkshopName} workshop for {selectedWorkshopDays} day(s) in {selectedLocationName}.";
                WorkshopCostValueLabel = selectedWorkshopCost.ToString("C");
                LocationCostValueLabel = totalLocationCost.ToString("C");
                DiscountLabel = nameDiscountString;
                DiscountValueLabel = $"-{registrationDiscount.ToString("C")}";
                TotalCostValueLabel = totalWorkshopCost.ToString("C");
            }

        }
        #endregion
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

    }
}
