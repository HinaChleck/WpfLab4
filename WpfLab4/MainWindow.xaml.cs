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

namespace WpfLab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
                InitializeComponent();
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double rateDollar = Convert.ToDouble(rate.Text);
                double sumDollar = Convert.ToDouble(sum.Text);
                double resDouble = rateDollar * sumDollar;
                resSum.Text = resDouble.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            try 
            { 
            double rateDollar1 = Convert.ToDouble(rate1.Text);
            double sumDollar1 = Convert.ToDouble(sum1.Text);
            double resDouble1 = rateDollar1 * sumDollar1;
            resSum1.Text = resDouble1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            try
            { 
            double rateDollar2 = Convert.ToDouble(rate2.Text);
            double sumDollar2 = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateDollar2 * sumDollar2;
            resSum2.Text = resDouble2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            try
            { 
            double rateDollar3 = Convert.ToDouble(rate3.Text);
            double sumDollar3 = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateDollar3 * sumDollar3;
            resSum3.Text = resDouble3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click2_0(object sender, RoutedEventArgs e)
        {
            try
            { 
            double distance = Convert.ToDouble(dist.Text);
            double resDist = distance * 0.0254;
            res.Text = resDist.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_Click2_1(object sender, RoutedEventArgs e)
        {
            try
            { 
            double distance1 = Convert.ToDouble(dist1.Text);
            double resDist1 = distance1 * 0.3048;
            res1.Text = resDist1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_Click2_2(object sender, RoutedEventArgs e)
        {
            try
            {
                double distance2 = Convert.ToDouble(dist2.Text);
                double resDist2 = distance2 * 1609.34;
                res2.Text = resDist2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void Button_Click2_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double distance3 = Convert.ToDouble(dist3.Text);
                double resDist3 = distance3 * 1066.8;
                res3.Text = resDist3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
