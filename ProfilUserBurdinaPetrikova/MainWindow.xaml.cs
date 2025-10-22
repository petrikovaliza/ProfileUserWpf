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

namespace ProfilUserBurdinaPetrikova
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

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AgeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void CityCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SubscribeCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateProfileBurron_Click(object sender, RoutedEventArgs e)
        {
            string userInfo = $"{NameTextBox.Text}, {AgeSlider.Value} лет.\n";
            userInfo += $"Город: {CityCombobox.Text}.\n";
            userInfo += SubscribeCheckBox.IsChecked == true ? "Подписан на рассылку." : "Не подписан на рассылку.";

            OutputTextBLock.Text = userInfo;

            var newBrush = new LinearGradientBrush();
            newBrush.StartPoint = new Point(0, 0);
            newBrush.EndPoint = new Point(1, 1);
            newBrush.GradientStops.Add(new GradientStop(Colors.LightGreen, 0.0));
            newBrush.GradientStops.Add(new GradientStop(Colors.DarkGreen, 1.0));

            ((Button)sender).Background = newBrush;
            ((Button)sender).Content = "Профиль обновлен!";
        }
    }
}
