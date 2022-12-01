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

namespace pract5
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
        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митрофанов Роман Валерьевич ИСП-31\nСоздать класс Triad (тройка нечетных чисел).\n Создать необходимые методы и свойства.Определить метод сравнения двух триад на равенство.\nСоздать перегруженный метод сравнения трех триад на равенство.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CompareNumber_Click(object sender, RoutedEventArgs e)
        {
            Triad triadOne = new Triad
            {
                First = Convert.ToInt32(firstTriadA.Text),
                Second = Convert.ToInt32(secondTriadA.Text),
                Third = Convert.ToInt32(thirdTriadA.Text)
            };
            Triad triadTwo = new Triad
            {
                First = Convert.ToInt32(firstTriadB.Text),
                Second = Convert.ToInt32(secondTriadB.Text),
                Third = Convert.ToInt32(thirdTriadB.Text)
            };
            bool result;
            if (triadOne.Compare(triadTwo))
            {
                result = true;
                MessageBox.Show("Триады А и В равны");
            }
            else MessageBox.Show("Триады А и В не равны");
        }

        private void CompareNumber2_Click(object sender, RoutedEventArgs e)
        {
            Triad triadOne = new Triad
            {
                First = Convert.ToInt32(firstTriadA.Text),
                Second = Convert.ToInt32(secondTriadA.Text),
                Third = Convert.ToInt32(thirdTriadA.Text)
            };

            Triad triadTwo = new Triad
            {
                First = Convert.ToInt32(firstTriadB.Text),
                Second = Convert.ToInt32(secondTriadB.Text),
                Third = Convert.ToInt32(thirdTriadB.Text)
            };

            Triad triadThree = new Triad
            {
                First = Convert.ToInt32(firstTriadC.Text),
                Second = Convert.ToInt32(secondTriadC.Text),
                Third = Convert.ToInt32(thirdTriadC.Text)
            };
            if (triadOne.Compare(triadTwo, triadThree))
            {
                MessageBox.Show("Все триады равны");
            }
            else MessageBox.Show("Все триады не равны");
        }
        }
    }
}
