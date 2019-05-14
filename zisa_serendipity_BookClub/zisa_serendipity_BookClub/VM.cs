using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace zisa_serendipity_BookClub
{
    class VM: INotifyPropertyChanged
    {
        private int input = 0;
        public int Input
        {
            get { return input; }
            set { input = value; CalculateResult(); NotifyChanged(); }
        }
        private string output = "";
        public string Output
        {
            get { return output; }
            set { output = value; NotifyChanged(); }
        }

        int FIRST_THRESH_BOOK = 0;
        int SECOND_THRESH_BOOK = 1;
        int THIRD_THRESH_BOOK = 2;
        int FOURTH_THRESH_BOOK = 3;
        int FIFTH_THRESH_BOOK = 4;

        int FIRST_THRESH_POINT = 0;
        int SECOND_THRESH_POINT = 5;
        int THIRD_THRESH_POINT = 15;
        int FOURTH_THRESH_POINT = 30;
        int FIFTH_THRESH_POINT = 60;

        //int bookQuantity=0;
        
        int points;
        
        public void CalculateResult()
        {
            if(Input== FIRST_THRESH_BOOK)
            {
                points = FIRST_THRESH_POINT;
            }
            else if(Input == SECOND_THRESH_BOOK)
            {
                points = SECOND_THRESH_POINT;
            }
            else if (Input == THIRD_THRESH_BOOK)
            {
                points = THIRD_THRESH_POINT;
            }
            else if (Input == FOURTH_THRESH_BOOK)
            {
                points = FOURTH_THRESH_POINT;
            }
            else if (Input == FIFTH_THRESH_BOOK)
            {
                points = FIFTH_THRESH_POINT;
            }
            else
            {
                points = FIFTH_THRESH_POINT;
            }

            Output =$" You have earned {points.ToString("0")} points for buying {Input} number of books";

            //Input = bookQuantity;



            //switch(Input)
            //{
            //  case (FIRST_THRESH_BOOK):
            //        points = 0;
            //        break;
            //}

        }
        public void Clear()
        {
            Input = 0;
            Output = "";
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
