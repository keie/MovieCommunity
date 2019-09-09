

namespace BusinessRules.Connection
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class BrConnection
    {
        public string ConnectionString { get; set; }

        public BrConnection()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["LocalHouse"].ConnectionString;
        }
    }
}
