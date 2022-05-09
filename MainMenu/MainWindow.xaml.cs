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

namespace Halcyon.MainMenu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
           System.Environment.Exit(0);

        }
        private void Credit(object sender, RoutedEventArgs e)
        {
            ShowCreditPage();
        }
        private void Info(object sender, RoutedEventArgs e)
        {
            ShowInfoPage();
        }
        private void Play(object sender, RoutedEventArgs e)
        {
            var Playform = new StoryMode.MainWindow();

            Playform.Show();
        }

        public void ShowCreditPage()
        {
            dialogBox.Visibility = Visibility.Visible;
            dialogBox.Source = new BitmapImage(new Uri("/Images/creditPage.png", UriKind.RelativeOrAbsolute));

        }

        public void ShowInfoPage()
        {
            dialogBox.Visibility = Visibility.Visible;
            dialogBox.Source = new BitmapImage(new Uri("/Images/infoPage.png", UriKind.RelativeOrAbsolute));

        }
        public void HideImage(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape && dialogBox.Visibility == Visibility.Visible)
            {
                dialogBox.Visibility = Visibility.Hidden;
                e.Handled = true;
            }         
        }
    }
}
