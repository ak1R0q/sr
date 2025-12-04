using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sr
{
    internal class Settlement
    {
        private Building[] buildings = new Building[5];
        private int budget;

        public int Budget
        {
            get { return budget; }
        }

        public Building[] Buildings
        {
            get { return buildings; }
        }
        public Settlement(int budget)
            { this.budget = budget; }
        public void AddBuilding(Building building)
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                if ((buildings[i] == null) & (budget - building.BuildCost >= 0)) { buildings[i] = building; budget -= building.BuildCost; return; }
                if (i == buildings.Length) { Console.WriteLine("oshibka"); return; }
            }
        }
        public void GetTotalProduction()
        {
            int TotalRes = 0;
            for (int i = 0;i < buildings.Length;i++)
            { if  (buildings[i] != null) { TotalRes += buildings[i].Production; } }
            Console.WriteLine("Тотальное производство: " + TotalRes);
        }
        public void ShowBuildings()
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] != null)
                {
                    buildings[i].DisplayInfo();
                }
            }
        }
    }
}
