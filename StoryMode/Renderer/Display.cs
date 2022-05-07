using Halcyon.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Halcyon.Renderer
{
    class Display : FrameworkElement
    {
        IGameLogic model;
        Size size;

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public void SetupModel(IGameLogic model)
        {
            this.model = model;
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            
            if (model != null && size.Width > 0 && size.Height > 0)
            {
                double rectWidth = size.Width / model.GameMatrix.GetLength(1);
                double rectHeight = size.Height / model.GameMatrix.GetLength(0);

                for (int i = 0; i < model.GameMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < model.GameMatrix.GetLength(1); j++)
                    {

                    }
                }
            }
        }
    }
}
