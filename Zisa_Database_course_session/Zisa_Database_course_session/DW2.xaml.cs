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
using System.Windows.Shapes;

namespace Zisa_Database_course_session
{
    /// <summary>
    /// Interaction logic for DW2.xaml
    /// </summary>
    public partial class DW2 : Window
    {
        VM vm;
        public DW2(VM vm)
        {
            this.vm = vm;
            InitializeComponent();
            DataContext = vm;
            vm.GetCourseList();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
