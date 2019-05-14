using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zisa_magic_dates
{
    class VM : INotifyPropertyChanged
    {
        #region PropertyDefinition
        private int month = 0;
        public int Month
        {
            get { return month; }
            set { month=value;  NotifyChanged(); }
        }
        private int day = 0;
        public int Day
        {
            get { return day; }
            set { day=value;  NotifyChanged(); }
        }
        private int year = 0;
        public int Year
        {
            get { return year; }
            set { year=value; NotifyChanged(); }
        }
        private string result = "";
        public string Result
        {
            get { return result; }
            set { result=value; NotifyChanged(); }
        }
        #endregion
        #region Logic
        //method check the magic date
        public void CheckMagicDate()
        {
            if (Month<1 || Month > 12)
            {
                Result = "Enter a two digit number for month";
                return;
            }
            if (Day < 1 || Day > 31)
            {
                Result = "Enter a two digit number for day";
                return;
            }
            if (Year < 0 || Year > 99)
            {
                Result = "Enter a two digit number year";
                return;

            }

            if (Month * Day == Year)
            {
                Result = $"{ Month}/{Day}/{Year}! It is a magic date!!";
            }
            else
            {
                Result = $"{ Month}/{Day}/{Year}! It is not a magic date!!";

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
