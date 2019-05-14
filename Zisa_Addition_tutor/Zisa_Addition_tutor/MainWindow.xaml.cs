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

namespace Zisa_Addition_tutor
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

        private void BtnNewProblem_Click(object sender, RoutedEventArgs e)
        {
            Window_Loaded(sender,e);
            vm.Clear();
        }

        private void BtnViewResult_Click(object sender, RoutedEventArgs e)
        {
            vm.CheckAnswer();
            vm.Save();
        }
        //method create random numbers and question everytime window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            vm.RandonNumberGenerator();
            vm.CreateQuestion();

        }
    }
}
