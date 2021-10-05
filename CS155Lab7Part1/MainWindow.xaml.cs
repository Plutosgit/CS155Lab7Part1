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

namespace CS155Lab7Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "Calculator";

            lstOperator.Items.Add("+");
            lstOperator.Items.Add("-");
            lstOperator.Items.Add("*");
            lstOperator.Items.Add("/"); 
            lstOperator.Items.Add("%");
            lstOperator.Items.Add("^");

            txtLeft.Focus();
        }

        private void txtLeft_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLeft.SelectAll();

        }

        private void txtRight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lblAnswer != null) lblAnswer.Content = "";

        }

        private void txtRight_GotFocus(object sender, RoutedEventArgs e)
        {
            txtRight.SelectAll();
        }

        private void cmdAnswer_OnClick(object sender, RoutedEventArgs e)
        {
            //double dLeft, dRight;
            //bool bResult;
            String s = "";

            /*bResult = Double.TryParse(txtLeft.Text, out dLeft);
            if (!bResult)
            {
                MessageBox.Show("Please enter a valid number!");
                txtLeft.Focus();
                return;
            }

            bResult = Double.TryParse(txtRight.Text, out dRight);
            if (!bResult)
            {
                MessageBox.Show("Please enter a valid number!");
                txtRight.Focus();
                return;
            }
            */

            try
            {
                int nOperation = lstOperator.SelectedIndex;
                decimal dLeft1 = Convert.ToDecimal(txtLeft.Text);
                decimal dRight1 = Convert.ToDecimal(txtRight.Text);
                decimal dAnswer = 0;

                switch (nOperation)
                {
                    case 0:
                        dAnswer = dLeft1 + dRight1;
                        break;

                    case 1:
                        dAnswer = dLeft1 - dRight1;
                        break;

                    case 2:
                        dAnswer = dLeft1 * dRight1;
                        break;

                    case 3:
                        dAnswer = dLeft1 / dRight1;
                        break;

                    case 4:
                        dAnswer = dLeft1 % dRight1;
                        break;

                    case 5:
                        //dAnswer = power(dLeft1,dRight1);
                        break;

                    default:
                        dAnswer = 0;
                        s = "Invalid Operation!";
                        break;
                
                }
                if (s.Length > 0)
                {
                    MessageBox.Show(s);
                }
                else
                {
                    lblAnswer.Content = dAnswer.ToString();
                }
                

            }
            catch(DivideByZeroException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtLeft_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lblAnswer != null) lblAnswer.Content = "";
        }

        private void lstOperator_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lblAnswer != null) lblAnswer.Content = "";

        }
    }
}
