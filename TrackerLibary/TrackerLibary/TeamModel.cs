using System.Collections.Generic;

namespace TrackerLibary
{
    public class TeamModel
    {
        public List<PersonModel> TeamsMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }

    }
}