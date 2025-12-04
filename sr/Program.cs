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
            Building firstbuilding = new Building("inferno", 100, 150);
            Building secondbuilding = new Building("tesla", 50, 80);
            Settlement settlement = new Settlement(300);
            settlement.AddBuilding(firstbuilding);
            settlement.AddBuilding(secondbuilding);
            settlement.GetTotalProduction();
            settlement.ShowBuildings();
            GameManager gamemanager = new GameManager(settlement, 3);
            gamemanager.SimulateProduction();
        }
    }
}
