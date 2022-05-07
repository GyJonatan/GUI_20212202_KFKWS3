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
        public enum MapItems
        {
            player, road, wall, talkPrincess, Dojo, fightSkeleton, fightNinja, fightSensei,
        }

        public MapItems[,] GameMatrix { get; set; }
       
        public GameLogic()
        {
            LoadInside();
        }
        private void LoadInside()
        {
            string json = File.ReadAllText("collision.json"); // map : 40*33

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
        }


        private MapItems ConvertToEnum(int matrixItem)
        {
            switch (matrixItem)
            {
                case 1: return MapItems.wall;
                case 2: return MapItems.fightSkeleton;
                case 3: return MapItems.fightNinja;
                case 4: return MapItems.fightSensei;
                case 5: return MapItems.talkPrincess;
                case 8: return MapItems.Dojo;
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


            if (GameMatrix[i, j] == MapItems.road)
            {
                GameMatrix[i, j] = MapItems.player;
                GameMatrix[old_i, old_j] = MapItems.road;
            }
            else if (GameMatrix[i, j] == MapItems.Dojo)
            {
                //megnyitni a takuzu-t
                
            }
            else if (GameMatrix[i, j] == MapItems.talkPrincess)
            {
                //beszelgetos_ablak
            }
            else if (GameMatrix[i, j] == MapItems.fightSensei || GameMatrix[i, j] == MapItems.fightNinja || GameMatrix[i, j] == MapItems.fightSkeleton)
            {
                //boss-fightok
            }


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
