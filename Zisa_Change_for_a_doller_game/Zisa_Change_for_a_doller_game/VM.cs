using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Zisa_Change_for_a_doller_game
{
    class VM : INotifyPropertyChanged
    {
        private string pennie = "0";
        public string Pennie
        {
            get { return pennie; }
            set { pennie = value; NotifyChanged(); }
        }
        private string nickle = "0";
        public string Nickle
        {
            get { return nickle; }
            set { nickle = value; NotifyChanged(); }
        }
        private string dime = "0";
        public string Dime
        {
            get { return dime; }
            set { dime = value; NotifyChanged(); }
        }
        private string quarter = "0";
        public string Quarter
        {
            get { return quarter; }
            set { quarter = value; NotifyChanged(); }
        }

        private string result = "";
        public string Result
        {
            get { return result; }
            set { result = value; NotifyChanged(); }
        }
        public void Calculate()
        {
            decimal PENNIE = 0.01M;
            decimal NICKLE = 0.05M;
            decimal DIME = 0.10M;
            decimal QUARTER = 0.25M;
            int MAXIMUM_NUMBER = 101;
            try
            {
                int numOfPennie = int.Parse(Pennie);
                int numOfNickle = int.Parse(Nickle);
                int numOfDime = int.Parse(Dime);
                int numOfQuarter = int.Parse(Quarter);
                if (numOfPennie< MAXIMUM_NUMBER && numOfNickle< MAXIMUM_NUMBER && 
                    numOfDime< MAXIMUM_NUMBER && numOfQuarter< MAXIMUM_NUMBER)
                {
                    if((numOfPennie* PENNIE)+(numOfNickle* NICKLE)+(numOfDime* DIME)+(numOfQuarter* QUARTER) == 1)
                    {
                        Result = "Congratulations !! ";
                    }
                    else if((numOfPennie * PENNIE) + (numOfNickle * NICKLE) + (numOfDime * DIME) + (numOfQuarter * QUARTER) < 1)
                    {
                        Result = "Less than one doller !! ";

                    }
                    else
                    {
                        Result = "Greater than one doller !! ";

                    }
                }
                else
                {
                    MessageBox.Show("Enter any number between 1 and 100");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
