using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr
{
    internal class GameManager
    {
        private Settlement settlement;
        private int gameTime;

        public int GameTime
        { get { return gameTime; }}

        public GameManager(Settlement settlement, int gameTime)
        {
            this.settlement = settlement;
            this.gameTime = gameTime;
        }
        public void SimulateProduction()
        {
            int res = 0;
            for (int i = 0; i < settlement.Buildings.Length; i++)
            {
                if (settlement.Buildings[i] != null) { res += (settlement.Buildings[i].Production * gameTime); }
                else { break; }

            }
            Console.WriteLine($"За {GameTime} минут будет произведено {res} баобабов");
        }

    }
}
