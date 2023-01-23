using System.ComponentModel.DataAnnotations;

namespace SocerApi.Models
{
    public class PostPlayerInfo
    {
       [Key] public int playerId { get; set; }
        public string playerName { get; set; }
        public string countryName { get; set; }
        public string clubName { get; set; }
        public string playingPosition { get; set; }
        public int numberOfplayeingWorldCup { get; set; }
        public int numberOfPlayingMatchInWorldCup { get; set; }
        

    }
}
