//Fatima Johora
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

namespace Zisa_Calorie_c
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void BtnApple_Click(object sender, RoutedEventArgs e)
        {
            vm.FruitName=ViewModel.FruitType.Apple;
        }

        private void BtnBanana_Click(object sender, RoutedEventArgs e)
        {
            vm.FruitName = ViewModel.FruitType.Banana;

        }

        private void Btnorange_Click(object sender, RoutedEventArgs e)
        {
            vm.FruitName = ViewModel.FruitType.Orange;

        }

        private void BtnPear_Click(object sender, RoutedEventArgs e)
        {
            vm.FruitName = ViewModel.FruitType.Pear;

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            vm.TotalCalorie = 0;
        }
    }
}
