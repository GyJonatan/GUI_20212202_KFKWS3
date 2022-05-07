using Halcyon.StoryMode.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halcyon.StoryMode.Logic
{
    public class GameLogic : IGameLogic, IGameControl
    {
        //KELL MEG EZEN A SZARON DOLGOZNI
        //A MAPPOK 20x11esek 11 magas 20 szeles
        public enum MapItems
        { 
            player, road, wall, fight, talk
        }

        public MapItems[,] GameMatrix { get; set; }
       
        public GameLogic()
        {
            LoadInside();
        }
        private void LoadInside()
        {
            string json = File.ReadAllText("collision.json"); // map : 40*33

            //int[,] temp = JsonConvert.DeserializeObject<int[,]>(json);

            int[,] temp = new int[33, 40];

            int count = 0;
            int max = 0;

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                while (count < 40) 
                {
                    int character = int.Parse(json[max + count].ToString());
                    temp[i, count++] = character;
                }
                
                max += count;
                count = 0;
            }

            temp[26, 26] = 9;
            GameMatrix = new MapItems[temp.GetLength(0), temp.GetLength(1)];

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    GameMatrix[i, j] = ConvertToEnum(temp[i, j]);
                }
            }

            //GameMatrix[26, 26] = MapItems.player; //31 27
        }


        private MapItems ConvertToEnum(int matrixItem)
        {
            switch (matrixItem)
            {
                case 1: return MapItems.wall;
                case 2: return MapItems.fight;
                case 3: return MapItems.talk;
                case 9: return MapItems.player;

                default:
                    return MapItems.road;
            }
        }

        //MOVEMENT
        public enum Directions
        { 
            up, down, left, right
        }
        public void Move(Directions direction)
        {
            var coords = WhereAmI();
            int i = coords[0];
            int j = coords[1];
            int old_i = i;
            int old_j = j;
            switch (direction)
            {
                case Directions.up:
                    if (i - 1 >= 0)
                    {
                        i--;
                    }
                    break;
                case Directions.down:
                    if (i + 1 < GameMatrix.GetLength(0))
                    {
                        i++;
                    }
                    break;
                case Directions.left:
                    if (j - 1 >= 0)
                    {
                        j--;
                    }
                    break;
                case Directions.right:
                    if (j + 1 < GameMatrix.GetLength(1))
                    {
                        j++;
                    }
                    break;
                default:
                    break;
            }

            //EZT AT KELL IRNI

            if (GameMatrix[i, j] == MapItems.road)
            {
                GameMatrix[i, j] = MapItems.player;
                GameMatrix[old_i, old_j] = MapItems.road;
            }
            //else if (GameMatrix[i, j] == MapItems.door)
            //{
            //    //todo level vége
            //    if (levels.Count > 0)
            //    {
            //        LoadNext(levels.Dequeue());
            //    }

            //}

        }

        private int[] WhereAmI()
        {
            for (int i = 0; i < GameMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GameMatrix.GetLength(1); j++)
                {
                    if (GameMatrix[i, j] == MapItems.player)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
