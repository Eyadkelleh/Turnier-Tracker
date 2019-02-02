namespace TrackerLibary
{
    /// <summary>
    /// Represents what the prize is for the given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePerecentage { get; set; }

        public PrizeModel()
        {
            
        }

        public  PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePerecentage)
        {
            PlaceName = placeName;
            int placeNumberVAlue = 0;
            int.TryParse(placeNumber, out placeNumberVAlue);

        }
    }
}