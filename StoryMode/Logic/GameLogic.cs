using Halcyon.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halcyon.Logic
{
    public class GameLogic : IGameLogic, IGameControl
    {
        //KELL MEG EZEN A SZARON DOLGOZNI
        //A MAPPOK 20x11esek 11 magas 20 szeles
        public enum MapItems
        { 
            player, road, door, blocked, enemy
        }

        public MapItems[,] GameMatrix { get; set; }
       
        public GameLogic()
        {
            var mapFiles = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "Maps"), "*.map");

            foreach (var item in mapFiles)
            {
                LoadInside(item);
            }
        }
        private void LoadInside(string path)
        {
            //átirni, hogy a collision legyen blocked enum a mapon
            string[] lines = File.ReadAllLines(path);
            GameMatrix = new MapItems[int.Parse(lines[1]), int.Parse(lines[0])];
            for (int i = 0; i < GameMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GameMatrix.GetLength(1); j++)
                {
                    GameMatrix[i, j] = ConvertToEnum(lines[i + 2][j]);
                }
            }
        }

        static Map ImportMap(string mapName)
        {
            string json = File.ReadAllText(mapName + ".json");
            var maps = JsonConvert.DeserializeObject<List<Map>>(json).Where(x => x.name == "collision").Select(x => x.data);
            return new Map(maps.FirstOrDefault());
        }

        private MapItems ConvertToEnum(char v)
        {
            switch (v)
            {
                // EZEN MODOSITANI JSON-ra
                case 'P': return MapItems.player;
                case 'D': return MapItems.door;
                case 'b': return MapItems.blocked;
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
            /*
            if (GameMatrix[i, j] == LabyItem.floor)
            {
                GameMatrix[i, j] = LabyItem.player;
                GameMatrix[old_i, old_j] = LabyItem.floor;
            }
            else if (GameMatrix[i, j] == LabyItem.door)
            {
                //todo level vége
                if (levels.Count > 0)
                {
                    LoadNext(levels.Dequeue());
                }

            }
            */
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
