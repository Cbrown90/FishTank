using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishSaver.Models
{
    public abstract class Fish
    {
        public string Name { get; set; }
        public abstract double FoodNeeded { get; }
        public abstract string Type { get; }

    }
}