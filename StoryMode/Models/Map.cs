﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halcyon.Models
{
    public class Map
    {
        public int[,] data;
        public string name;
        public Map(int[,] data)
        {
            this.data = data;
        }
    }
}