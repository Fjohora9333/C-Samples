using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

//Fatima Tuj Johora,Section:1

namespace Joe_s_Ski_Resort
{
    public class VM: INotifyPropertyChanged
    {
        double fuelAmount = 10;

        #region Properties

        private BindingList<SkiType> skies;
        public BindingList<SkiType> Skies
        {
            get { return skies; }
            set { skies = value; NotifyChanged(); }
        }

        private BindingList<FuelType> fuels;
        public BindingList<FuelType> Fuels
        {
            get { return fuels; }
            set { fuels = value; NotifyChanged(); }
        }

        private string skiCharge;
        public string SkiCharge
        {
            get { return SkiCharge; }
            set { SkiCharge = value; NotifyChanged(); }
        }

        private string fuelCharge;
        public string FuelCharge
        {
            get { return fuelCharge; }
            set { fuelCharge = value; NotifyChanged(); }
        }

        private SkiType selectedSki;
        public SkiType SelectedSki
        {
            get { return selectedSki; }
            set { selectedSki = value; NotifyChanged(); }
        }
        private FuelType selectedFuel;
        public FuelType SelectedFuel
        {
            get { return selectedFuel; }
            set { selectedFuel = value; NotifyChanged(); }
        }
        private int day;
        public int Day
        {
            get { return day; }
            set { day = value; NotifyChanged(); }
        }
        private double totalCharge;
        public double TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; NotifyChanged(); }
        }
        #endregion
        #region Logic

        public VM()
        {
            SkiType SingleSeat = new SkiType("SingleSeat", 200);
            SkiType TwoSeat = new SkiType("TwoSeat", 300);
            SkiType ThreeSeat = new SkiType("ThreeSeat", 500);

            FuelType RegulaFuel = new FuelType("RegulaFuel", 1.25);
            FuelType MidgradeFuel = new FuelType("MidgradeFuel", 1.75);
            FuelType PremiumFuel = new FuelType("PremiumFuel", 2.00);

            Skies = new BindingList<SkiType>() { SingleSeat, TwoSeat, ThreeSeat};
            Fuels = new BindingList<FuelType>() { RegulaFuel, MidgradeFuel, MidgradeFuel };

        }
        public void CalculateTotalCharge()
        {
            TotalCharge = ((SelectedSki.SkiCharge * Day) + (SelectedFuel.FuelCharge * fuelAmount));
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
