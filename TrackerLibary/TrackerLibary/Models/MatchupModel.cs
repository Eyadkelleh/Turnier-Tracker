using System.Collections.Generic;

namespace TrackerLibary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> MatchupEntryModels { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}