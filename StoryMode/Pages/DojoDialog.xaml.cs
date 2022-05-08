using Halcyon.TakuzuGame.Logic;
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

namespace StoryMode.Pages
{
    /// <summary>
    /// Interaction logic for DojoDialog.xaml
    /// </summary>
    public partial class DojoDialog : Page
    {
        public DojoDialog()
        {
            InitializeComponent();
        }

        private void EnterTraining_Click(object sender, RoutedEventArgs e)
        {
            var form = new Halcyon.TakuzuGame.MainWindow();
            form.ShowDialog();

            var ClickedButton = e.OriginalSource as NavigationButton;

            NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void Leave_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
