using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTracker
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database == true)
            {
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            else
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
