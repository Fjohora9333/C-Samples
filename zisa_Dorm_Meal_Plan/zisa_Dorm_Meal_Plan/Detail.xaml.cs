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

//Fatima Tuj Johora, Section:1
namespace zisa_Dorm_Meal_Plan
{
    /// <summary>
    /// Interaction logic for Detail.xaml
    /// </summary>
    public partial class Detail : Window
    {
        VM vm = null;
        public Detail(VM vm)
        {
            this.vm = vm;
            InitializeComponent();
            DataContext = vm;
        }
    }
}
