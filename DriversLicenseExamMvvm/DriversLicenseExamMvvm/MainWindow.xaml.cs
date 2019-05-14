//<!--Fatima Johora-->
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

namespace DriversLicenseExamMvvm
{
    /// <summary>
    /// Handles the the Xaml Window events and sets up the VM for the Xaml Window 
    /// </summary>
    public partial class MainWindow : Window
    {
        //initializing the VM class Object
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        // event handler for Select button click. Calls the OpenFileDialig method from the vm object class.
        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            vm.GetFileName();
        }

        // event handler for Compare button click. Calls the Compare method from the vm object class.
        private void BtnCompare_Click(object sender, RoutedEventArgs e)
        {
            vm.Compare();
        }

        //event handler for Clear button click. Calls the ClearAllText method from the vm object class.
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            vm.ClearAllText();
        }
    }
}
