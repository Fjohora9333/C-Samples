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

namespace Zisa_Database_course_session
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DW dw = null;
        DW2 dw2 = null;

        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.GetCourseOffering();

        }

        //create new second window ehwn ListBox selection is changed
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dw == null)
            {
                dw = new DW(vm)
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                dw.Closed += DW_Closed;
                dw.Show();
            }
            vm.GetSelectedCourseOffering();
        }
        private void DW_Closed(object sender, System.EventArgs e) => dw = null;

        private void BtnAddNew_Click(object sender, RoutedEventArgs e)
        {
            if (dw2 == null)
            {
                dw2 = new DW2(vm)
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                dw2.Closed += DW2_Closed;
                dw2.Show();
            }
        }
        private void DW2_Closed(object sender, System.EventArgs e) => dw2 = null;

    }
}
