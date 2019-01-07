namespace TrackerLibary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in the matchup.
        /// </summary>
        public TeamModel TeamCompting { get; set; }
        /// <summary>
        /// Reresents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this came
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        ///
        /// </param>
        public MatchupEntryModel(double initialScore) 
        {
          
        }
    }
}