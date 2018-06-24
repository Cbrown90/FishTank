using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishSaver.Models
{
    public class Goldfish : Fish
    {
        public override double FoodNeeded
        {
            get
            { return 0.1; }
        }
        public override string Type
        {
            get
            { return "Goldfish"; }
        }
    }
}