using Calculator_Model;
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



namespace WPF_Window

{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        public Calculator _calculator;         
        public CalculatorWindow()
        {
            _calculator = new Calculator();
            InitializeComponent();
        }

        private void tbxNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum1.Text, out double  num1);
            if (success)
            {
                _calculator.Num1 = num1;

            }
            else
            {
                lbResult.Content = "Invalid input";
            
            }
        }

        private void tbxNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum2.Text, out double num2);
            if (success)
            {
                _calculator.Num2 = num2;

            }
            else
            {
                lbResult.Content = "Invalid input";

            }

        }        

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Content = _calculator.Add();            
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Content = _calculator.Subtract();      

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Content = _calculator.Divide();
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Content = _calculator.Multiply();
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Content = _calculator.Remainder();
        }
    }
}
