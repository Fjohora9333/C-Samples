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

namespace Zisa_finalPrac_Calorie_Counter
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

        private void BtnApple_Click(object sender, RoutedEventArgs e)
        {
            vm.FruitName = VM.FruitType.Apple;
        }

        private void BtnBanana_Click(object sender, RoutedEventArgs e)
        {
            vm.FruitName = VM.FruitType.Banana;
        }

        private void BtnOrange_Click(object sender, RoutedEventArgs e)
        {
            vm.FruitName = VM.FruitType.Orange;

        }

        private void BtnPear_Click(object sender, RoutedEventArgs e)
        {
            vm.FruitName = VM.FruitType.Pear;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            vm.Clear();
            vm.TotalCalorie = 0;
           
            vm.NumOfApple = "";
            vm.NumOfBanana = "";
            vm.NumOfOrange = "";
            vm.NumOfPear = "";
        }
    }
}
