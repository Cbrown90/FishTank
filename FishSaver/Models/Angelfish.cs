using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishSaver.Models
{
    public class Angelfish : Fish
    {
        public override double FoodNeeded
        {
            get
            { return 0.2; }
        }
        public override string Type
        {
            get
            { return "Angelfish"; }
        }
    }
}