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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(Value1TextBox.Text);
            int y = Convert.ToInt32(Value2TextBox.Text);
            int sum = x + y;

            ResultTextBlock.Text = sum.ToString();
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(Value1TextBox.Text);
            int y = Convert.ToInt32(Value2TextBox.Text);
            int min = x - y;

            ResultTextBlock.Text = min.ToString();
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(Value1TextBox.Text);
            int y = Convert.ToInt32(Value2TextBox.Text);
            int div = x / y;

            ResultTextBlock.Text = div.ToString();
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(Value1TextBox.Text);
            int y = Convert.ToInt32(Value2TextBox.Text);
            int mul = x * y;

            ResultTextBlock.Text = mul.ToString();
        }
    }
}
