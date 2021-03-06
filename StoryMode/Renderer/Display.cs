using Halcyon.StoryMode.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Halcyon.StoryMode.Renderer
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

            double rectWidth = size.Width / model.GameMatrix.GetLength(1);
            double rectHeight = size.Height / model.GameMatrix.GetLength(0);

            drawingContext.DrawRectangle(new ImageBrush
                                   (new BitmapImage(new Uri(Path.Combine("Images", "surface.png"), UriKind.RelativeOrAbsolute))), new Pen(Brushes.Black, 0),
                                    new Rect(0, 0, size.Width, size.Height));

            
            for (int i = 0; i < model.GameMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < model.GameMatrix.GetLength(1); j++)
                {
                    ImageBrush brush = new ImageBrush();                    

                    switch (model.GameMatrix[i,j])
                    {
                        case MapItems.player:
                            brush = new ImageBrush
                                   (new BitmapImage(new Uri(Path.Combine("Images", "player.png"), UriKind.RelativeOrAbsolute)));
                            break;
                        case MapItems.fightSkeleton:
                            brush = new ImageBrush
                                   (new BitmapImage(new Uri(Path.Combine("Images", "enemySkeleton.png"), UriKind.RelativeOrAbsolute)));
                            break;
                        case MapItems.fightNinja:
                            brush = new ImageBrush
                                   (new BitmapImage(new Uri(Path.Combine("Images", "enemyNinja.png"), UriKind.RelativeOrAbsolute)));
                            break;
                        case MapItems.fightSensei:
                            brush = new ImageBrush
                                   (new BitmapImage(new Uri(Path.Combine("Images", "enemySensei.png"), UriKind.RelativeOrAbsolute)));
                            break;
                        case MapItems.talkPrincess:
                            brush = new ImageBrush
                                   (new BitmapImage(new Uri(Path.Combine("Images", "talkPrincess.png"), UriKind.RelativeOrAbsolute)));
                            break;
                        case MapItems.Dojo:
                            brush = new ImageBrush
                                   (new BitmapImage(new Uri(Path.Combine("Images", "talkDojoMaster.png"), UriKind.RelativeOrAbsolute)));
                            break;
                        default:
                            break;
                    }

                    drawingContext.DrawRectangle(brush
                                    , new Pen(Brushes.Black, 0),
                                    new Rect(j * rectWidth, i * rectHeight, rectWidth, rectHeight)
                                    );
                }
            }
        }      
    }
}
