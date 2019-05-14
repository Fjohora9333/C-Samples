using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;
using System.Windows;

namespace Zisa_Addition_tutor
{
    class VM: INotifyPropertyChanged
    {
        private string title = "";
        public string Title
        {
            get { return title; }
            set { title = value; NotifyChanged(); }
        }
        private string question = "";
        public string Question
        {
            get { return question; }
            set { question = value; NotifyChanged(); }
        }
        private int answer = 0;
        public int Answer
        {
            get { return answer; }
            set { answer = value; NotifyChanged(); }
        }
        private string result = "";
        public string Result
        {
            get { return result; }
            set { result = value; NotifyChanged(); }
        }

        //logic
        public Random r = new Random();
        //variable declaration
        int Rand1;
        int Rand2;
         //creat 2 random numbers
        public void RandonNumberGenerator()
        {
            Rand1 = r.Next(100, 500);
            Rand2 = r.Next(100, 500);
        }
        //method to show question 
        public void CreateQuestion()
        {
            Title = "Your Math Problem";
            Question = $"Calculate {Rand1}+{ Rand2}=";
        }
        public void CheckAnswer()
        {
            Title = "Your Answer";
            try
            {
                if (Rand1 + Rand2 == Answer)
                {
                    Result = $"Congratulations!! Your answer is right!";
                }
                else
                {
                    Result =$"Sory!! Your answer is not correct, correct answer is {Rand1+Rand2} !";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error occured:   { ex.Message}");

            }
            
        }
        public void Clear()
        {
            Answer = 0;
            Result = "";
        }

        public void Save()
        {
            string fileText;
            fileText = $"Question {Rand1}+{Rand2},{Environment.NewLine}";
            fileText += $"User's answer is {Answer}, {Environment.NewLine}";
            fileText += $"Correct answer is {Rand1 + Rand2} {Environment.NewLine}";
            // setting up the app, data and file path
            string appPath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            string dataPath = Path.Combine(appPath, "PROG8010");
            string filePath = Path.Combine(dataPath, "output.txt");
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            // overwritting population data to a file at the provided path
            File.WriteAllText(filePath, fileText);
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
