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
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }

        public  PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePerecentage)
        {
            PlaceName = placeName;
            int.TryParse(placeNumber, out var placeNumberValue);
            PlaceNumber = placeNumberValue;
            decimal.TryParse(prizeAmount, out var prizeAmountValue);
            PrizeAmount = prizeAmountValue;
            double.TryParse(prizePerecentage, out var prizePercentageValue);
            PrizePercentage = prizePercentageValue;
            

        }
    }
}