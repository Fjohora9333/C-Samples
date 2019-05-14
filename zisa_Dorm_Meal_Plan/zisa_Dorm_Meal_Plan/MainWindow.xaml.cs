using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Fatima Tuj Johora, Section:1
namespace zisa_Dorm_Meal_Plan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Detail dw = null;
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void BtnCalcTotal_Click(object sender, RoutedEventArgs e)
        {
            //call calc
            vm.CalculateTotalCharge();

            if (dw == null)
            {
                dw = new Detail(vm)
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                dw.Closed += DW_Closed;
                dw.Show();
            }
        }
        private void DW_Closed(object sender, System.EventArgs e) => dw = null;

    }
}
