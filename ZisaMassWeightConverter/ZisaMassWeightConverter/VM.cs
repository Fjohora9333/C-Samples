using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ZisaMassWeightConverter
{
    class VM : INotifyPropertyChanged
    {
        #region PropertyDefinition
        private double mass = 0;
        public double Mass
        {
            get { return mass; }
            set { mass = value; Convert(); ShowMessage(); NotifyChanged(); }
        }

        private string weight = "";
        public string Weight
        {
            get { return weight; }
            set { weight = value; NotifyChanged(); }
        }

        private string message = "";
        public string Message
        {
            get { return message; }
            set { message = value; NotifyChanged(); }
        }
        #endregion

        #region Logic
        public double GRAVITY_CONSTANT = 9.8;
        public double MAX_LIMIT = 1000;
        public double MIN_LIMIT = 10;
        double weightDouble;
        //method convert mass to weight
        public void Convert()
        {
            weightDouble = Mass * GRAVITY_CONSTANT;
            Weight = weightDouble.ToString("0.00");
        }

        //method show message on label content
        public void ShowMessage()
        {
            if(weightDouble > MAX_LIMIT)
            {
                Message = " It is too heavy";
            }
            else if(weightDouble < MIN_LIMIT)
            {
                Message = " It is too light";
            }
        }

        //method clear all labels and texts
        public void Clear()
        {
            Mass = 0;
            Weight = "";
            Message = "";
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
