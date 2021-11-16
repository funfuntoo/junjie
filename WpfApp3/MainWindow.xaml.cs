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

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b,c;
            
            a = Convert.ToDouble(textbox1.Text);
            b= Convert.ToDouble(textbox2.Text);
            c= Math.Round(a + b, 0, MidpointRounding.AwayFromZero);
            if(c%2==0)
            {
                label1.Content = "四捨五入結果為" + c + "為偶數";
            }
            else
            {
                label1.Content = "四捨五入結果為" + c + "為奇數";
            }
            
        }
    }
}
