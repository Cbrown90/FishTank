using FishSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace FishSaver.Controllers
{
    public class HomeController : Controller
    {
        static Tank FishTank = new Tank();
        public ActionResult Index()
        {
            return View(FishTank);
        }

        public ActionResult AddFish(string name, string type)
        {
            Fish NewFish;
            try
            {
                switch (type)
                {
                    case "Goldfish":
                        NewFish = new Goldfish()
                        {
                            Name = name
                        };
                        break;
                    case "Angelfish":
                        NewFish = new Angelfish()
                        {
                            Name = name
                        };
                        break;
                    case "Babelfish":
                        NewFish = new Babelfish()
                        {
                            Name = name
                        };
                        break;
                    default:
                        throw new Exception("Invalid Type OF Fish");
                }

                FishTank.AddFishToTank(NewFish);
            }
            catch (Exception ex)
            {
                //Log Invalid fish type
                //Return to user there has been an errror
            }
            return View("Index", FishTank);
        }

        public ActionResult ExportToXML()
        {
            XDocument xdoc = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),

        new XElement("FishTank",
        from fish in FishTank.FishInTank
        select new XElement("Fish",
            new XElement("Name", fish.Name),
            new XElement("Type", fish.Type),
            new XElement("FoodNeed", fish.FoodNeeded))));

            // Write the document to the file system            
            xdoc.Save("C:/temp/fish.xml");

            return View("Index", FishTank);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}