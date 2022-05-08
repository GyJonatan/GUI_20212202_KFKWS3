using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Halcyon.MainMenu
{
    class MainWindowViewModel : ObservableRecipient
    {
        public ICommand StartCommand { get; set; }
        public ICommand ExitCommand { get; set; }
        public ICommand CreditCommand { get; set; }

        public MainWindowViewModel()
        {

        }
    }

}
