using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halcyon.TakuzuGame.Logic
{
    public enum State
    {
        Empty,
        Zero,
        One
    }
    public class Takuzu: IGameModel
    {
        public int Dimension { get; private set; }
        public State[,] Map { get; private set; }
        public State[,] Solution { get; private set; }

        public Takuzu(int dim)
        {
            this.Dimension = dim;
            this.Map = new State[dim,dim];
            this.Solution = new State[dim,dim];


            ImportFbf(dim);
            ;
            //Import(dim);
        }

        private void ImportFbf(int dim)
        {
            Random rnd = new Random();
            string json = File.ReadAllText("start.json");
            List<char[,]> maps = JsonConvert.DeserializeObject<List<char[,]>>(json);
            int selectedIndex = rnd.Next(0, maps.Count);
            char[,] selected = maps.Where(x => x.GetLength(0) == dim)
                                   .ElementAt(selectedIndex);


            json = File.ReadAllText("solution.json");
            List<char[,]> solutions = JsonConvert.DeserializeObject<List<char[,]>>(json);
            char[,] selectedSolution = solutions.Where(x => x.GetLength(0) == dim)
                                                .ElementAt(selectedIndex);

            for (int i = 0; i < selected.GetLength(0); i++)
            {
                for (int j = 0; j < selected.GetLength(1); j++)
                {
                    switch (selected[i, j])
                    {
                        case ' ': this.Map[i, j] = State.Empty; 
                            break;
                        case '0': this.Map[i, j] = State.Zero; 
                            break;
                        case '1': this.Map[i, j] = State.One; 
                            break;
                    }
                }
            }

            for (int i = 0; i < selectedSolution.GetLength(0); i++)
            {
                for (int j = 0; j < selectedSolution.GetLength(1); j++)
                {
                    switch (selectedSolution[i, j])
                    {
                        case ' ':
                            this.Solution[i, j] = State.Empty;
                            break;
                        case '0':
                            this.Solution[i, j] = State.Zero;
                            break;
                        case '1':
                            this.Solution[i, j] = State.One;
                            break;
                    }
                }
            }


        }

        

        public Takuzu getCopy()
        {
            return new Takuzu(Dimension) { Map = this.Map };
        }
        void Import(int dim)
        {
            Random rnd = new Random();
            string json = File.ReadAllText(Directory.GetCurrentDirectory() + "/takuzus.json");
            var takuzus = JsonConvert.DeserializeObject<List<Takuzu>>(json).Where(x => x.Dimension == dim);
            Takuzu sel = takuzus.ElementAt(rnd.Next(0, takuzus.Count()));

            this.Dimension = sel.Dimension;
            this.Map = sel.Map;

            
        }        

        public void SetState(int x, int y, State state)
        {
            if (IsValidPosition(x, y)) this.Map[x, y] = state;
            else throw new Exception("State can't be set due to unvalid parameters.");

        }
        public State GetState(int x, int y)
        {
            if (IsValidPosition(x, y)) return this.Map[x, y];
            else throw new Exception("State can't be retrieved due to unvalid parameters.");
        }

        public bool IsComplete()
        {
            foreach (State state in this.Map)
            {
                if (state == State.Empty) return false;
            }
            return true;
        }
        public bool IsSolved()
        {
            for (int i = 0; i < this.Map.GetLength(0); i++)
            {
                for (int j = 0; j < this.Map.GetLength(1); j++)
                {
                    if (this.Map[i, j] != this.Solution[i, j]) return false;
                }
            }
            return true;
        }
        bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < this.Dimension &&
                   y >= 0 && y < this.Dimension;
        }

        public bool IsInItsPlace(int x, int y, State state)
        {
            return this.Map[x, y] == state;
        }
    }
}
