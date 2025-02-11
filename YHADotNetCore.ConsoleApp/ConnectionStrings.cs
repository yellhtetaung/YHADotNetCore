using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YHADotNetCore.ConsoleApp
{
    internal class ConnectionStrings
    {
        public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "DotnetTrainingBatch4",
            UserID = "sa",
            Password = "Yehtetaung@2481998"
        };
    }
}
