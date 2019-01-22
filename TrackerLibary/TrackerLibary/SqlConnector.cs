using System;

namespace TrackerLibary
{
    /// <summary>
    /// Create connection to data base in order to save the Model
    /// </summary>
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Save a new prize to database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CretePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
