//<!--Fatima Johora-->
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Media;


namespace DriversLicenseExamMvvm
{
    class VM : INotifyPropertyChanged
    {
        //initializing Constant
        #region Constants
        const uint PASSING_MARK = 15;
        #endregion

        //initializing Properties
        #region PropertyDefinition
        private BindingList<string> correctAnswerData = new BindingList<string>();
        public BindingList<string> CorrectAnswerData
        {
            get { return correctAnswerData; }
            set { correctAnswerData = value;NotifyChanged(); }
        }

        private BindingList<string> studentAnswerData = new BindingList<string>();
        public BindingList<string> StudentAnswerData
        {
            get { return studentAnswerData; }
            set { studentAnswerData = value; NotifyChanged(); }
        }

        private BindingList<string> incorrectAnswerData = new BindingList<string>();
        public BindingList<string> IncorrectAnswerData
        {
            get { return incorrectAnswerData; }
            set { incorrectAnswerData = value; NotifyChanged(); }
        }

        private string selectedFileName = "";
        public string SelectedFileName
        {
            get { return selectedFileName; }
            set { selectedFileName = value; NotifyChanged(); }
        }

        private string result = "";
        public string Result
        {
            get { return result; }
            set { result = value; NotifyChanged(); }
        }

        private string correctMarks = "";
        public string CorrectMarks
        {
            get { return correctMarks; }
            set { correctMarks = value; NotifyChanged(); }
        }

        private string incorrectMarks = "";
        public string IncorrectMarks
        {
            get { return incorrectMarks; }
            set { incorrectMarks = value; NotifyChanged(); }
        }

        protected Brush labelColor;
        public Brush LabelColor
        {
            get { return labelColor; }
            set { labelColor = value; NotifyChanged(); }
        }
        #endregion

        #region Logic
        //method open dialog box to select saved files
        public void GetFileName()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                selectedFileName = openFileDialog.FileName;
        }

        //method Compare two sets of question from saved files and show result
        public void Compare()
        {
            if (selectedFileName == "")
            {
               MessageBox.Show("Please Select a sample file");
               return;
            }
            else
            {
                string[] correctAnswerDataArray = File.ReadAllLines("correctAnswer.txt");
                string[] studentAnswerDataArray = File.ReadAllLines(selectedFileName);
                int correctcount = 0;
                int incorrectcount = 0;

                for (int i = 0; i < correctAnswerDataArray.Length; i++)
                {
                    CorrectAnswerData.Add(correctAnswerDataArray[i]);
                    StudentAnswerData.Add(studentAnswerDataArray[i]);
                    if(correctAnswerDataArray[i] == studentAnswerDataArray[i])
                    {
                        correctcount++;
                    }
                    else
                    {
                        incorrectcount++;
                        string[] spliteElementArray = studentAnswerDataArray[i].Split('.');
                        IncorrectAnswerData.Add(spliteElementArray[0]);
                    }
                }
                if (correctcount < PASSING_MARK)
                {
                    Result = $"Sorry you didn't pass the exam.";
                    LabelColor = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                }
                else
                {
                    Result = $"Congratulations!! You have passed the exam.";
                    LabelColor = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                }
                CorrectMarks = $"Total number of correct answers= {correctcount}";
                IncorrectMarks = $"Total number of incorrect answers= {incorrectcount}";
            }
        }

        //method clear all list boxes ansd labels
        public void ClearAllText()
        {
            CorrectAnswerData.Clear();
            StudentAnswerData.Clear();
            IncorrectAnswerData.Clear();
            Result = "";
            CorrectMarks = "";
            IncorrectMarks = "";
            LabelColor = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
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
