using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishSaver.Models;

namespace FishSaver.Tests
{
    [TestClass]
    public class TankTests
    {
        [TestMethod]
        public void Empty_Tank_Needs_Zero_Food()
        {
            Tank FishTank = new Tank();

            string ExpectedValueOfFeed = "0";
            string ActualValueOfFeed = FishTank.Feed();            

            Assert.AreEqual(ExpectedValueOfFeed, ActualValueOfFeed);
        }

        [TestMethod]
        public void Goldfish_In_Tank_Needs_Point_One_Food()
        {
            Tank FishTank = new Tank();
            FishTank.AddFishToTank(new Goldfish());

            string ExpectedValueOfFeed = "0.1";
            string ActualValueOfFeed = FishTank.Feed();

            Assert.AreEqual(ExpectedValueOfFeed, ActualValueOfFeed);
        }

        [TestMethod]
        public void Angel_In_Tank_Needs_Point_Two_Food()
        {
            Tank FishTank = new Tank();
            FishTank.AddFishToTank(new Angelfish());

            string ExpectedValueOfFeed = "0.2";
            string ActualValueOfFeed = FishTank.Feed();

            Assert.AreEqual(ExpectedValueOfFeed, ActualValueOfFeed);
        }

        [TestMethod]
        public void Babelfish_In_Tank_Needs_Point_Three_Food()
        {
            Tank FishTank = new Tank();
            FishTank.AddFishToTank(new Babelfish());

            string ExpectedValueOfFeed = "0.3";
            string ActualValueOfFeed = FishTank.Feed();

            Assert.AreEqual(ExpectedValueOfFeed, ActualValueOfFeed);
        }

        [TestMethod]
        public void Two_Babelfish_Three_Angelfish_Ten_Goldfish_In_Tank_Needs_Two_Point_Two_Food()
        {
            Tank FishTank = new Tank();

            for(int b = 0; b < 2; b++)            
            FishTank.AddFishToTank(new Babelfish());

            for (int b = 0; b < 3; b++)
                FishTank.AddFishToTank(new Angelfish());

            for (int b = 0; b < 10; b++)
                FishTank.AddFishToTank(new Goldfish());

            string ExpectedValueOfFeed = "2.2";
            string ActualValueOfFeed = FishTank.Feed();

            Assert.AreEqual(ExpectedValueOfFeed, ActualValueOfFeed);
        }
    }
}
