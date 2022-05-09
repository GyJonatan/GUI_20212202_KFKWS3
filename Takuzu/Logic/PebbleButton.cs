using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Halcyon.TakuzuGame.Logic
{
    public class PebbleButton : Button
    {

        public ImageSource ImageSource { get; set; }
        public State pebbleState { get; set; }

        public bool isClickable { get; set; }

        public int xPos { get; set; }
        public int yPos { get; set; }

        public bool toggleClick()
        {
            return this.isClickable = !this.isClickable;
        }
    }
}
