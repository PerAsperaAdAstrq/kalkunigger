using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace kalkunigger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int a;
        int b;
        int c;
        string z;
        string y;
        int dec;
        int bin;
        int hex;
        int oct;
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //ljevi textbox
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //srednji textbox
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            //desni textbox
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //jednako
            if(dec == 1)
            {
                y = z + srednji.Text;
                desni.Text = Convert.ToString(new DataTable().Compute(y, null));
            }
            else if(bin == 1)
            {
                y = z + srednji.Text;
                c = Convert.ToInt32(new DataTable().Compute(y, null));
                desni.Text = Convert.ToString(c, 2);
            }
            else if (hex == 1)
            {
                y = z + srednji.Text;
                c = Convert.ToInt32(new DataTable().Compute(y, null));
                desni.Text = Convert.ToString(c, 16);
            }
            else if (oct == 1)
            {
                y = z + srednji.Text;
                c = Convert.ToInt32(new DataTable().Compute(y, null));
                desni.Text = Convert.ToString(c, 8);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //plus
            z = ljevi.Text + "+";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //minus
            z = ljevi.Text + "-";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //puta
            z = ljevi.Text + "*";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //djeli
            z = ljevi.Text + "/";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //buttonDecimal
            dec = 1;
            bin = 0;
            hex = 0;
            oct = 0;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            //buttonBinary
            dec = 0;
            bin = 1;
            hex = 0;
            oct = 0;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            //buttonHexadecimal
            dec = 0;
            bin = 0;
            hex = 1;
            oct = 0;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            //buttonOctal
            dec = 0;
            bin = 0;
            hex = 0;
            oct = 1;
        }
    }
}
