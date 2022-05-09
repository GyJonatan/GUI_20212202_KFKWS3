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

namespace Halcyon.TakuzuGame
{
    public partial class MainWindow : Window
    {
        GameMechanic logic;
        Takuzu takuzu;

        
        

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedPebble = e.OriginalSource as PebbleButton;

            if (!ClickedPebble.isClickable) return;

            switch (ClickedPebble.pebbleState)
            {
                case State.Empty:
                    ClickedPebble.ImageSource =
                        new BitmapImage(new Uri(System.IO.Path.Combine("Images", "TileBlue.png"),
                        UriKind.RelativeOrAbsolute));
                    ClickedPebble.pebbleState = State.Zero;

                    takuzu.Map[ClickedPebble.xPos, ClickedPebble.yPos] = ClickedPebble.pebbleState;
                    break;

                case State.Zero:
                    ClickedPebble.ImageSource =
                        new BitmapImage(new Uri(System.IO.Path.Combine("Images", "TileGreen.png"),
                        UriKind.RelativeOrAbsolute));
                    ClickedPebble.pebbleState = State.One;

                    takuzu.Map[ClickedPebble.xPos, ClickedPebble.yPos] = ClickedPebble.pebbleState;
                    break;

                case State.One:
                    ClickedPebble.ImageSource =
                        new BitmapImage(new Uri(System.IO.Path.Combine("Images", "TileEmpty.png"),
                        UriKind.RelativeOrAbsolute));
                    ClickedPebble.pebbleState = State.Empty;

                    takuzu.Map[ClickedPebble.xPos, ClickedPebble.yPos] = ClickedPebble.pebbleState;
                    break;
            }

            ClickedPebble.Background = new ImageBrush() { ImageSource = ClickedPebble.ImageSource };

            if (takuzu.IsComplete())
            {
                if (takuzu.IsSolved())
                {
                    finishButton.Visibility = Visibility.Visible;
                    finishButton.IsEnabled = true;
                    logic.ToggleClickForAllPebbles();
                }
            }
        }
        

        public MainWindow()
        {

            InitializeComponent();
            takuzu = new Takuzu(6);
            logic = new GameMechanic(takuzu);


            for (int i = 0; i < logic.Pebbles.GetLength(0); i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < logic.Pebbles.GetLength(0); i++)
            {
                for (int j = 0; j < logic.Pebbles.GetLength(1); j++)
                {
                    PebbleButton pebble = logic.Pebbles[i, j];
                    pebble.BorderThickness = new Thickness(1);
                    pebble.Background = new ImageBrush() { ImageSource = pebble.ImageSource };
                    Grid.SetRow(pebble, i);
                    Grid.SetColumn(pebble, j);
                    pebble.Click += this.Grid_Click;
                    grid.Children.Add(pebble);
                }
            }
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void ClosePractice(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }


    }
}
