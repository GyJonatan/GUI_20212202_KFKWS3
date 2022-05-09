using Halcyon.StoryMode.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Halcyon.StoryMode.Controller
{
    class GameController
    {
        IGameControl control;

        public GameController(IGameControl control)
        {
            this.control = control;
        }

        public void KeyPressed(Key key)
        {
            switch (key)
            {
                case Key.Up:
                    control.Move(GameLogic.Directions.up);
                    break;
                case Key.Down:
                    control.Move(GameLogic.Directions.down);
                    break;
                case Key.Left:
                    control.Move(GameLogic.Directions.left);
                    break;
                case Key.Right:
                    control.Move(GameLogic.Directions.right);
                    break;
            }
        }
    }
}
