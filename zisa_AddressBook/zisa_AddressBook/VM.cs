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

namespace zisa_AddressBook
{
    public class VM : INotifyPropertyChanged
    {
        //taking a binding list of data type Personentry
        private BindingList<PersonEntry> person;
        public BindingList<PersonEntry> Person
        {
            get { return person; }
            set { person = value; NotifyChanged(); }
        }
        
        private PersonEntry selectedPerson = null;
        public PersonEntry SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value; NotifyChanged(); }
        }

        //in VM constructore the personInfo
        public VM()
        {
            //read all lines from file PersonInfo.txt and enter the lines in an arrey named PersonInfo
            string[] PersonInfo = File.ReadAllLines("personInfo.txt");

            //binding the list to main window
            BindingList<PersonEntry> PersonList = new BindingList<PersonEntry>();
            for (int i = 0; i < PersonInfo.Length; i++)
            {
                //splite each element of PersonInfo arrey at ',' and save then in an arrey elements
                string[] elements = PersonInfo[i].Split(',');
                //take each elements of the elements arrey as a parameter of Personentry
                PersonList.Add(new PersonEntry(elements[0], elements[1], elements[2]));

            }
            Person = PersonList;
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
