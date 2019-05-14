using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace zisa_Employee_CLass
{
    public class VM: INotifyPropertyChanged
    {
       
        private BindingList<Employee> personList;
        public BindingList<Employee> PersonList
        {
            get { return personList; }
            set { personList = value; NotifyChanged(); }
        }

        public VM()
        {
            Employee Fatima = new Employee("Fatima", 1, "none", "none");
            Employee Shah = new Employee("Shah", 3, "none", "none");
            Employee ABC = new Employee("ABC", 1, "none", "none");

            BindingList<Employee> EmployeeList = new BindingList<Employee>() { Fatima, Shah, ABC };

            PersonList = EmployeeList;
        }
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

    }//end of VM class


}
