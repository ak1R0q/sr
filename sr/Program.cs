using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building firstbuilding = new Building("ivanzolo2004", 100, 167);
            Building secondbuilding = new Building("vanzolochevski", 50, 501);
            Building thirdbuilding = new Building("wf", 150, 30);
            Settlement settlement = new Settlement(300);
            settlement.AddBuilding(firstbuilding);
            settlement.AddBuilding(secondbuilding);
            settlement.AddBuilding(thirdbuilding);
            settlement.ShowBuildings();
            settlement.GetTotalProduction();
            GameManager gamemanager = new GameManager(settlement, 3);
            gamemanager.SimulateProduction();
        }
    }
}
