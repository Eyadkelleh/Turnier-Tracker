using System.Collections.Generic;
using TrackerLibrary;
using  System.Configuration;

namespace TrackerLibary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO:  Set up the sql connector properly
                SqlConnector sqlConnector = new SqlConnector();
                Connections.Add(sqlConnector);
            }

            if (textFiles)
            {
                // TODO: Create the text Connection 
                TextConnection textConnection = new TextConnection();
                Connections.Add(textConnection);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
