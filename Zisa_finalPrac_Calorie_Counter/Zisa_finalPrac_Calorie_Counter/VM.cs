using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zisa_finalPrac_Calorie_Counter
{
    class VM : INotifyPropertyChanged
    {
        public enum FruitType { None, Apple, Banana, Orange, Pear };
        decimal appleCalorie = 80;
        decimal bananaCalorie = 115;
        decimal orangeCalorie = 90;
        decimal pearCalorie = 120;
        int numApple;
        int numBanana;
        int numOrange;
        int numPear;

        private string numOfApple = "";
        public string NumOfApple
        {
            get { return numOfApple; }
            set { numOfApple = value; NotifyChanged(); }
        }
        private string numOfBanana = "";
        public string NumOfBanana
        {
            get { return numOfBanana; }
            set { numOfBanana = value; NotifyChanged(); }
        }
        private string numOfOrange = "";
        public string NumOfOrange
        {
            get { return numOfOrange; }
            set { numOfOrange = value; NotifyChanged(); }
        }
        private string numOfPear = "";
        public string NumOfPear
        {
            get { return numOfPear; }
            set { numOfPear = value; NotifyChanged(); }
        }

        private decimal totalCalorie;
        public decimal TotalCalorie
        {
            get { return totalCalorie; }
            set { totalCalorie = value; NotifyChanged(); }
        }
        private FruitType fruitName = FruitType.None;
        public FruitType FruitName
        {
            get { return fruitName; }
            set { fruitName = value; CalculateTotal(); NotifyChanged(); }
        }

        public void CalculateTotal()
        {
            //switch (FruitName)
            //{
            //    case "Apple":
            //        TotalCalorie += appleCalorie;
            //        break;
            //}

            if (FruitName == FruitType.Apple)
            {
                numApple++;
                if (numApple > 1)
                {
                    NumOfApple= $" {numApple} Apples";
                }
                else
                {
                    NumOfApple = $"Apple {numApple}";
                }
                TotalCalorie += appleCalorie;
            }
            else if (FruitName == FruitType.Banana)
            {
                numBanana++;
                NumOfBanana = $"Banana {numBanana}";
                TotalCalorie += bananaCalorie;

            }
            else if (FruitName == FruitType.Orange)
            {
                numOrange++;
                NumOfOrange= $"Orange {numOrange}";
                TotalCalorie += orangeCalorie;

            }
            else if (FruitName == FruitType.Pear)
            {
                numPear++;
                NumOfPear = $"Pear {numPear}";
                TotalCalorie += pearCalorie;
            }
        }

        public void Clear()
        {
            numApple = 0;
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
