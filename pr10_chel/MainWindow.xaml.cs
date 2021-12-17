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

namespace pr10_chel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> mas = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int s) == false) e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numbersList.Items.Clear();
            mas.Clear();
            int numbersCounter = 0;
            Random rnd = new Random();

            for (int i = 0; i < Convert.ToInt32(inputBox.Text); i++)
            {
                mas.Add(rnd.Next(-10, 10));
                numbersList.Items.Add(mas[i]);
            }
            foreach (var item in mas)
            {
                if (item == 5 || item == -5) numbersCounter++;
            }
            outputBox.Text = numbersCounter.ToString();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Челяев Никита ИСП-31\nДан массив в диапазоне [-10;10] найти количество значений равных 5 и -5.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
