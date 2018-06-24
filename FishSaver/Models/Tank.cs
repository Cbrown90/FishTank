using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishSaver.Models
{
    public class Tank
    {
        public List<Fish> FishInTank;

        public Tank()
        {
            FishInTank = new List<Fish>();
        }

        public void ExportToXML()
        { }

        public void AddFishToTank(Fish fish)
        {
            FishInTank.Add(fish);
        }

        public string Feed()
        {
            double FoodToFeed = 0.0;
            foreach(Fish fish in FishInTank)
            {
                FoodToFeed += fish.FoodNeeded;
            }
            return FoodToFeed.ToString();
        }
    }
}