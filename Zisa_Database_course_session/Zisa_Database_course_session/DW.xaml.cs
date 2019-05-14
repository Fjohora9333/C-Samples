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
    /// Interaction logic for DW.xaml
    /// </summary>
    public partial class DW : Window
    {
        VM vm = null;
        public DW(VM vm)
        {
            InitializeComponent();
            DataContext = vm;
            this.vm = vm;
        }
    }
}
