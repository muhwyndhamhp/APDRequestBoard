using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDRequestBoardLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        
        public static void InitializeConnection(bool database, bool textFile)
        {
            if(database)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            

            if (textFile)
            {
                //TODO - Create the TextConnection (if needed)
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
