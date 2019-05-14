using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zisa_Calorie_c
{
    class ViewModel : INotifyPropertyChanged
    {
        public enum FruitType { None,Apple,Banana,Orange,Pear};
        decimal APPLE_CALORIE = 80M;
        decimal BANANA_CALORIE = 115M;
        decimal ORANGE_CALORIE = 90M;
        decimal PEAR_CALORIE = 120M;


        private decimal totalCalorie=0;
        public decimal TotalCalorie
        {
            get { return totalCalorie; }
            set { totalCalorie = value; NotifyChanged(); }
        }


        private FruitType fruitName = FruitType.None;
        public FruitType FruitName
        {
            get { return fruitName; }
            set { fruitName = value; TotalCalorieCalc(); NotifyChanged(); }
        }



        public void TotalCalorieCalc()
        {
            if (FruitName == FruitType.Apple)
            {
                TotalCalorie += APPLE_CALORIE;
            }
            else if (FruitName == FruitType.Banana)
            {
                TotalCalorie += BANANA_CALORIE;
            }
            else if (FruitName == FruitType.Orange)
            {
                TotalCalorie += ORANGE_CALORIE;
            }
            else if (FruitName == FruitType.Pear)
            {
                TotalCalorie += PEAR_CALORIE;
            }
            else
            {
                TotalCalorie += 0;
            }




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
