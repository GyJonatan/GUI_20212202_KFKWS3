using Halcyon.StoryMode.Controller;
using Halcyon.StoryMode.Logic;
using StoryMode.Pages;
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

namespace Halcyon.StoryMode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameController controller;
        public static MainWindow Instance;
        public MainWindow()
        {
            Instance = this;
            InitializeComponent();
            GameLogic logic = new GameLogic();
            display.SetupModel(logic);
            controller = new GameController(logic);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            display.SetSize(new Size(grid.ActualWidth, grid.ActualHeight));
            display.InvalidateVisual();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }

            controller.KeyPressed(e.Key);
            display.InvalidateVisual();
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            display.SetSize(new Size(grid.ActualWidth, grid.ActualHeight));
            display.InvalidateVisual();
        }

        public void ShowPrincessDialog1()
        {
            leaveButton.Visibility = Visibility.Visible;
            leaveButton.IsEnabled = true;

            dialogBox.Visibility = Visibility.Visible;
            dialogBox.Source = new BitmapImage(new Uri("/Images/princessDialog1.png", UriKind.RelativeOrAbsolute));
        }
        public void ShowPrincessDialog2()
        {
            leaveButton.Visibility = Visibility.Visible;
            leaveButton.IsEnabled = true;

            dialogBox.Visibility = Visibility.Visible;
            dialogBox.Source = new BitmapImage(new Uri("/Images/princessDialog2.png", UriKind.RelativeOrAbsolute));
        }
        public void ShowDojomasterDialog()
        {
            trainingButton.Visibility = Visibility.Visible;
            trainingButton.IsEnabled = true;
            leaveButton.Visibility = Visibility.Visible;
            leaveButton.IsEnabled = true;

            dialogBox.Visibility = Visibility.Visible;
            dialogBox.Source = new BitmapImage(new Uri("/Images/dojomasterDialog.png", UriKind.RelativeOrAbsolute));

        }
        public void HideImage()
        {
            dialogBox.Visibility = Visibility.Hidden;
        }

        //private void EnterTraining_Click(object sender, RoutedEventArgs e, NavigationService navigationService)
        //{
        //    var form = new TakuzuGame.MainWindow();
        //    form.ShowDialog();

        //    var ClickedButton = e.OriginalSource as NavigationButton;
        //    navigationService.Navigate(ClickedButton.NavUri);
        //}

        private void EnterTraining_Click(object sender, RoutedEventArgs e)
        {
            var form = new Halcyon.TakuzuGame.MainWindow();
            form.ShowDialog();

            var ClickedButton = e.OriginalSource as NavigationButton;

            //NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void Leave_Click(object sender, RoutedEventArgs e)
        {
            HideImage();

            trainingButton.Visibility = Visibility.Hidden;
            trainingButton.IsEnabled = false;
            leaveButton.Visibility = Visibility.Hidden;
            leaveButton.IsEnabled = false;
        }
    }
}
