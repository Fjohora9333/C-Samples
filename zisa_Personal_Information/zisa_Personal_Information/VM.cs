using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace zisa_Personal_Information
{
    public class VM: INotifyPropertyChanged
    {
        public static Person FatimaJ { get; set; } = new Person("Fatima Johora", "432 Pastern Trail", 29, "222-333-4444");
        public static Person ShahC { get; set; } = new Person("Shah Chandon", "432 Pastern Trail", 40, "111-222-3333");
        public static Person GeorgeM { get; set; } = new Person("George Michle", "400 University Road", 20, "551-222-3333");
        //Define other properties to be used in Methods
        public string TemplateFile { get; set; } = "Name1; Address1; Age1; PhoneNumber1" + Environment.NewLine + "Name2; Address2; Age2; PhoneNumber2";

        private string newName = "";
        public string NewName
        {
            get { return newName; }
            set { newName = value; NotifyChanged(); }
        }
        private string newAddress = "";
        public string NewAddress
        {
            get { return newAddress; }
            set { newAddress = value; NotifyChanged(); }
        }

        private uint newAge = 0;
        public uint NewAge
        {
            get { return newAge; }
            set { newAge = value; NotifyChanged(); }
        }
        private string newPhone = "";
        public string NewPhone
        {
            get { return newPhone; }
            set { newPhone = value; NotifyChanged(); }
        }
        private BindingList<Person> people = new BindingList<Person>() { FatimaJ, ShahC, GeorgeM };
        public BindingList<Person> People
        {
            get { return people; }
            set { people = value; NotifyChanged(); }
        }
        private Person selectedPerson = null;
        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value; NotifyChanged(); }
        }
        private string selectedFileName = "";
        public string SelectedFileName
        {
            get { return selectedFileName; }
            set { selectedFileName = value; NotifyChanged(); }
        }

        #region Logic
        public void AddPerson()
        {
            if(newName=="" || newAddress=="" || newAge==0 || newPhone == "")
            {
                MessageBox.Show("Please fill all the fiels, Age in integer only","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                Person newPerson = new Person(newName, newAddress, newAge, newPhone);
                People.Add(newPerson);
            }
        }
        public void DeletePerson()
        {
            if (selectedPerson != null)
            {
                People.Remove(SelectedPerson);
            }
        }

       
        //Method download template file for person
        public void DownloadTemplateFile()
        {
            string appPath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            string dataPath = Path.Combine(appPath, "ProgPrac8010");
            string filePath = Path.Combine(dataPath, $"PersonImportTemplate.txt");
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }
            File.WriteAllText(filePath,TemplateFile);
        }
        //method select a file name
        public void SelectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                SelectedFileName = openFileDialog.FileName;
        }
        //Method Impert File containing (template) people information; adds people to the binding list person
        public void ImportFile()
        {
            if (SelectedFileName == "")
            {
                MessageBox.Show("Please select a file name containing People information", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string[] importLines = File.ReadAllLines(SelectedFileName);
                for(int i=0; i<importLines.Length; i++)
                {
                    try
                    {
                        var newInfo = importLines[i].Split(';');
                        People.Add(new Person(newInfo[0].Trim(), newInfo[1].Trim(), uint.Parse(newInfo[2].Trim()), newInfo[3].Trim()));

                    }
                    catch
                    {
                        MessageBox.Show($"Error in line {i + 1}. Please Download the template file and ensure that age is an integer valu",
                            "Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }
                }
            }
        }

        public void SavePeople()
        {
            string fileText = "";
            for( int j=0; j< fileText.Length; j++)
            {
                fileText += People[j];
                fileText += Environment.NewLine;
                string appPath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                string dataPath = Path.Combine(appPath, "ProgPrac8010");
                string filePath = Path.Combine(dataPath, $"People.txt");
                if (!Directory.Exists(dataPath))
                {
                    Directory.CreateDirectory(dataPath);
                }
                File.WriteAllText(filePath, fileText);
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
