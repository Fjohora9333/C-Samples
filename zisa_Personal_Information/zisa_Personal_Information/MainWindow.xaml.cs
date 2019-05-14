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

namespace zisa_Personal_Information
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DetailWindow dw=null;
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void BtnClearForm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            vm.AddPerson();
        }


        private void BtnViewDetail_Click(object sender, RoutedEventArgs e)
        {
            if (dw == null)
            {
                dw = new DetailWindow(vm)
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                dw.Closed += DW_Close;
                dw.Show();

            }
        }
        private void DW_Close(object sender, System.EventArgs e) => dw = null;

        private void BtnDownloadTemplate_Click_1(object sender, RoutedEventArgs e)
        {
            vm.DownloadTemplateFile();
        }

        private void BtnImportTemplate_Click(object sender, RoutedEventArgs e)
        {
            vm.SelectFile();
            vm.ImportFile();
        }

        private void BtnSavePeaple_Click(object sender, RoutedEventArgs e)
        {
            vm.SavePeople();
        }

        private void BtnDeletePeople_Click(object sender, RoutedEventArgs e)
        {
            vm.DeletePerson();
        }
       
    }
}
