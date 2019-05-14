using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Zisa_pennies_for_pay
{
    class VM : INotifyPropertyChanged
    {
        #region PropertyDefinition
        private int day = 0;
        public int Day
        {
            get { return day; }
            set { day = value; NotifyChanged(); }
        }
        private string result = "";
        public string Result
        {
            get { return result; }
            set { result = value; NotifyChanged(); }
        }
        #endregion

        #region Logic
        int MINIMUM_NUM_OF_DAY = 1;
        int MILLION_NUM_OF_WORKDAYS = 28;
        int TRILLION_NUM_OF_WORKDAYS = 48;
        int MAX_NUM_OF_WORKDAYS = 64;
        Int64 NUM_OF_PENNIES;
        public void CalculatePay()
        {
            if (Day < MINIMUM_NUM_OF_DAY)
            {
                Result = $"Enter a number greater than 0";
                Day = 0;
                Result = "";
            }
            else if(Day< MILLION_NUM_OF_WORKDAYS)
            {
                NUM_OF_PENNIES=(long)Math.Pow(2,(Day-1));
                Result = $"Pay is {NUM_OF_PENNIES} pennies.";
            }
            else if (Day< TRILLION_NUM_OF_WORKDAYS)
            {

                NUM_OF_PENNIES = (long)Math.Pow(2, (Day - 1));
                Result = $"Pay is {NUM_OF_PENNIES} pennies. You are a millionaire now!!";
            }
            else if (Day < MAX_NUM_OF_WORKDAYS)
            {

                NUM_OF_PENNIES = (long)Math.Pow(2, (Day - 1));
                Result = $"Pay is {NUM_OF_PENNIES} pennies. You are a trillionnaire now!!";
            }
            else
            {
                Result = $"It's a very big number, can not calculate";
            }
        }
        public void Save()
        {
            string fileText = "";
            fileText = $"Number of days:{Day},{Environment.NewLine}{Result}"+Environment.NewLine;
            string appPath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            string dataPath = System.IO.Path.Combine(appPath, "Prog8010Assignment");
            string filePath = System.IO.Path.Combine(dataPath, "PenniesforPay.txt");
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }
            File.AppendAllText(filePath, fileText);
            return;
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
