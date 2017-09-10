using BattlefieldStats;
using BattlefieldStats.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            StartClientAsync().Wait();
        }

        private static async Task StartClientAsync()
        {
            ///////////////////////////////////////////////////////////////////////////////
            // Visit https://battlefieldtracker.com/site-api to generation your own API Key
            ///////////////////////////////////////////////////////////////////////////////

            using (BattlefieldClient l_client = new BattlefieldClient("API_KEY"))
            {
                // Replace "playerName" by the player name you want to get
                RootObject l_playerInfo = await l_client.GetPlayerInfo("playerName");
            }
        }
    }
}
