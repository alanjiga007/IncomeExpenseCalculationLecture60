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

namespace Lecture60
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(textIncome.Text);
            int expenses = int.Parse(textExpenses.Text);
            int priceTheWish = int.Parse(textPriceTheWish.Text);
            int money = income - expenses;
            int howDay = priceTheWish / money;

            textSaveMoney.Text = howDay.ToString();

            MessageBox.Show(howDay.ToString());
        }
    }
}
