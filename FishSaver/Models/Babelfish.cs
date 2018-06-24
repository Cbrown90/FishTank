using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishSaver.Models
{
    public class Babelfish : Fish
    {
        public override double FoodNeeded
        {
            get
            { return 0.3; }
        }
        public override string Type
        {
            get
            { return "Babelfish"; }
        }
    }
}