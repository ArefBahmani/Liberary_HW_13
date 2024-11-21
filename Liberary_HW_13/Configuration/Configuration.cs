using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_HW_13.Configuration
{
    public static class Configuration
    {
        public static string ConnectionString { get; set; }

        static Configuration()
        {
     ConnectionString = @"Data Source=DESKTOP-J6I42F2\SQLEXPRESS;Initial Catalog=Liberary;User ID=SA;Password=123456;TrustServerCertificate=True;";
        }
    }
}
