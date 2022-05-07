using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;


namespace Halcyon.TakuzuGame.Logic
{
    public class GameMechanic
    {
        public PebbleButton[,] Pebbles { get; set; }
        IGameModel model;
        public GameMechanic(IGameModel model)
        {
            this.model = model;
            this.Pebbles = new PebbleButton[model.Map.GetLength(0),model.Map.GetLength(1)];
            this.FillPebbles();
        }
        private void FillPebbles()
        {
            for (int i = 0; i < Pebbles.GetLength(0); i++)
            {
                for (int j = 0; j < Pebbles.GetLength(1); j++)
                {
                    PebbleButton pebble = new PebbleButton() { xPos = i, yPos = j};
                    switch (model.Map[i, j])
                    {
                        case State.Empty:

                            pebble.ImageSource = new BitmapImage(
                                    new Uri(Path.Combine("Images", "TileEmpty.png"), UriKind.RelativeOrAbsolute));
                            pebble.pebbleState = State.Empty;
                            pebble.isClickable = true;
                            Pebbles[i, j] = pebble;

                            break;
                        case State.Zero:

                            pebble.ImageSource = new BitmapImage(
                                    new Uri(Path.Combine("Images", "TileBlue.png"), UriKind.RelativeOrAbsolute));
                            pebble.pebbleState = State.Zero;
                            pebble.isClickable = false;

                            Pebbles[i, j] = pebble;

                            break;
                        case State.One:

                            pebble.ImageSource = new BitmapImage(
                                    new Uri(Path.Combine("Images", "TileGreen.png"), UriKind.RelativeOrAbsolute));
                            pebble.pebbleState = State.One;
                            pebble.isClickable = false;

                            Pebbles[i, j] = pebble;

                            break;
                    }
                }
            }
        }
        public void ToggleClickForAllPebbles()
        {
            foreach (PebbleButton pebble in Pebbles)
            {
                pebble.toggleClick();
            }
        }
        
    }
}
