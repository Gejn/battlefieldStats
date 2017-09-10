using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlefieldStats.Data
{
    public class BasicStats
    {
        public List<object> completion { get; set; }
        public object equippedDogtags { get; set; }
        public object highlights { get; set; }
        public object highlightsByType { get; set; }
        public int kills { get; set; }
        public int wins { get; set; }
        public int deaths { get; set; }
        public double spm { get; set; }
        public double skill { get; set; }
        public object soldierImageUrl { get; set; }
        public double kpm { get; set; }
        public int losses { get; set; }
        public int timePlayed { get; set; }
        public object rank { get; set; }
        public object rankProgress { get; set; }
    }

    public class GameModeStat
    {
        public string name { get; set; }
        public string prettyName { get; set; }
        public double score { get; set; }
        public int losses { get; set; }
        public int wins { get; set; }
        public double winLossRatio { get; set; }
    }

    public class KitType
    {
    }

    public class KitStat
    {
        public double kills { get; set; }
        public KitType kitType { get; set; }
        public string name { get; set; }
        public string prettyName { get; set; }
        public double score { get; set; }
        public double secondsAs { get; set; }
    }

    public class VehicleStat
    {
        public double killsAs { get; set; }
        public string name { get; set; }
        public string prettyName { get; set; }
        public double timeSpent { get; set; }
        public double vehiclesDestroyed { get; set; }
    }

    public class Result
    {
        public double accuracyRatio { get; set; }
        public int avengerKills { get; set; }
        public double awardScore { get; set; }
        public BasicStats basicStats { get; set; }
        public double bonusScore { get; set; }
        public int dogtagsTaken { get; set; }
        public string favoriteClass { get; set; }
        public int flagsCaptured { get; set; }
        public int flagsDefended { get; set; }
        public List<GameModeStat> gameModeStats { get; set; }
        public int headShots { get; set; }
        public double heals { get; set; }
        public int highestKillStreak { get; set; }
        public double kdr { get; set; }
        public double killAssists { get; set; }
        public List<KitStat> kitStats { get; set; }
        public double longestHeadShot { get; set; }
        public double nemesisKills { get; set; }
        public double nemesisKillStreak { get; set; }
        public double repairs { get; set; }
        public double revives { get; set; }
        public object roundHistory { get; set; }
        public int roundsPlayed { get; set; }
        public int saviorKills { get; set; }
        public double squadScore { get; set; }
        public double suppressionAssist { get; set; }
        public List<VehicleStat> vehicleStats { get; set; }
    }

    public class Profile
    {
        public string trackerUrl { get; set; }
        public string displayName { get; set; }
        public int personaId { get; set; }
        public int platform { get; set; }
    }

    public class RootObject
    {
        public bool successful { get; set; }
        public Result result { get; set; }
        public Profile profile { get; set; }
        public string bbPrefix { get; set; }
    }
}
