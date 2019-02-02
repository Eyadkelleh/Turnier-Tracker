﻿using System;
using System.Data.SqlClient;
using Dapper;

namespace TrackerLibary
{
    /// <summary>
    /// Create connection to data base in order to save the Model
    /// </summary>
    public class SqlConnector : IDataConnection
    {
        private string localStringSQLName = "Tournament";
        /// <summary>
        /// Save a new prize to database.
        /// </summary>
        /// <param name="model"> The Prize information </param>
        /// <returns></returns>
        public PrizeModel CretePrize(PrizeModel model)
        {
            using (SqlConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(localStringSQLName)))
            {
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@PlaceNumber", model.PlaceNumber);
                dynamicParameters.Add("@PlaceName", model.PlaceName);
                dynamicParameters.Add("@PrizeAmount", model.PrizeAmount);
                dynamicParameters.Add("@PrizePerecentage", model.PrizePercentage);
            }

        }
    }
}
////@PlaceNumber int,
////@PlaceName nvarchar(50),
////@PrizeAmount money,
////@PrizePerecentage float,
////@id int = 0 output