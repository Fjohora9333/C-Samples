using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zisa_Database_Employee2
{
    public class VM : INotifyPropertyChanged
    {
        DB db = DB.GetInstance();

        private BindingList<Employee> employees;
        public BindingList<Employee> Employees
        {
            get { return employees; }
            set { employees = value; NotifyChanged(); }
        }

        private Employee selectedPerson;
        public Employee SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value; NotifyChanged(); }
        }
        private Employee personTOEdit;
        public Employee PersonTOEdit
        {
            get { return personTOEdit; }
            set { personTOEdit = value; NotifyChanged(); }
        }
        private double avgPayRate;
        public double AvgPayRate
        {
            get { return avgPayRate; }
            set { avgPayRate = value; NotifyChanged(); }
        }

        public VM()
        {
            //get a list of persons from the database
            Employees = new BindingList<Employee>(db.Get());
        }

        //
        public void SortDescending()
        {
            //Employees= new BindingList<Employee>(db.Get().Sort(new EmployeeSortByPay()));
            List<Employee> x = Employees.ToList<Employee>();
            x.Sort(new EmployeeSortByPay());
            Employees = new BindingList<Employee>(x);
        }
        public void GetAvgPayRate()
        {
            AvgPayRate=db.GetAvgPay();
        }
        public void GetLowestPayRate()
        {
            AvgPayRate = db.GetLowestPay();
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
