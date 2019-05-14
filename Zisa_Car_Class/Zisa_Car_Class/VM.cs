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

namespace Zisa_Car_Class
{
     public class VM : INotifyPropertyChanged
    {
        private BindingList<Car> carList;
        public BindingList<Car> CarList
        {
            get { return carList; }
            set { carList = value; NotifyChanged(); }
        }
        private Car selectedCar = null;
        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value; NotifyChanged(); }
        }

        public void Accelerate()
        {
            selectedCar.Speed += 5;
            SelectedCar = selectedCar;
        }
        public void Break()
        {
            if (selectedCar.Speed-5 < 0)
            {
                MessageBox.Show("Speed can not be negative");
            }
            else
            {
                selectedCar.Speed -= 5;
                SelectedCar = selectedCar;
            }
            
        }

        public VM()
        {
            Car Toyota08 = new Car("Toyota", 2008);
            Car Honda10 = new Car("Honda", 2010);
            Car Toyota10 = new Car("Toyota", 2010);
            Car Acura15 = new Car("Acura", 2015);

            carList = new BindingList<Car>() { Toyota08, Honda10, Toyota10, Acura15 };
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
