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

namespace Zisa_Database_Employee2
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

        private void BtnSortDescPay_Click(object sender, RoutedEventArgs e)
        {
            vm.SortDescending();
        }

        private void BtnAvgPayRate_Click(object sender, RoutedEventArgs e)
        {
            vm.GetAvgPayRate();
        }

        private void BtnLowPayRate_Click(object sender, RoutedEventArgs e)
        {
            vm.GetLowestPayRate();
        }
    }
}
