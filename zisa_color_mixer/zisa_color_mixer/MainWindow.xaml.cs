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


namespace zisa_color_mixer
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


        
        // Get value of each slider and fill the rectangle with these values when each slider's value changes
        private void color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color clr = Color.FromArgb(255, Convert.ToByte(SldRed.Value), Convert.ToByte(SldGreen.Value),Convert.ToByte(SldBlue.Value));
            RecOutputColor.Fill = new SolidColorBrush(clr);
        }
        //method to clear the text boxes when Button reset is clicked
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtRed.Text ="0";
            TxtGreen.Text ="0";
            TxtBlue.Text ="0";
        }
        //Method to chek the text box inputs are number only
        private void checkTextboxInput(System.Windows.Controls.TextBox textbox)
        {
            string strTxt=null;
            strTxt = textbox.Text;
            if(strTxt.Trim()=="")
            {
                return;
            }
            for(int i=0;  i<strTxt.Length; i++)
            {
                if (!char.IsNumber(strTxt[i]))
                {
                    MessageBox.Show("Please enter a number between 0 and 255", "Error Tip");
                    textbox.Text = "";
                    return;
                }
            }

        }

        private void TxtGreen_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkTextboxInput(TxtGreen);
        }

        private void TxtRed_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkTextboxInput(TxtRed);
        }

        private void TxtBlue_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkTextboxInput(TxtBlue);
        }
    }
}
