using System;
using System.Collections.Generic;
using System.IO;
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

namespace _9prac9
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
        private void add(object sender, RoutedEventArgs e)
            {
                Int32.TryParse(House.Text, out int house); Int32.TryParse(Flat.Text, out int flat);
                if (house >= 0 && flat >= 0)
                {
                    Students people = new Students(Surname.Text, Street.Text, Convert.ToString(house), Convert.ToString(flat));
                    dataGrid.Items.Add(people);
                }
            }
        private void tofind(object sender, RoutedEventArgs e)
        {
            int kol = 0;
            foreach (Students people in dataGrid.Items)
            {
                if (people.Street == streetsearch.Text)
                {
                    kol++;
                }
            }
            MessageBox.Show($"Количество учеников на улице {streetsearch.Text} = {kol}");
        }
        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31 Кузнецов Алексей Алексеевич. Описать, используя структуру, данные на учеников (фамилия, улица, дом, квартира).Вывести результат на экран. Вывести информацию, сколько учеников живет на заданной улице.");
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
