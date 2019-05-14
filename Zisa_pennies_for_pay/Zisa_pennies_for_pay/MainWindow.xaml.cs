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

namespace Zisa_pennies_for_pay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            vm.CalculatePay();
            BtnCalculate.Visibility = Visibility.Hidden;
            BtnSave.Visibility = Visibility.Visible;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            vm.Save();
            BtnCalculate.Visibility = Visibility.Visible;
            BtnSave.Visibility = Visibility.Hidden;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            BtnCalculate.Visibility = Visibility.Visible;
            BtnSave.Visibility = Visibility.Hidden;

            vm.Day = 0;
            vm.Result = "";
        }

        private void TxtDayNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int x = int.Parse(TxtDayNumber.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Occured: {ex.Message} ");
                TxtDayNumber.Text = "0";
            }
           

        }
    }
}
