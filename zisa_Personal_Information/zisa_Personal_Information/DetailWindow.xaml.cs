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

namespace zisa_Personal_Information
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        VM vm = null;
        public DetailWindow(VM vm)
        {
            this.vm = vm;
            InitializeComponent();
            DataContext = vm;
        }
    }
}
