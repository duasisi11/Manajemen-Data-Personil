using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace PERSONIL
{
    class Connection
    {
        internal static SqlConnection connect(){
             return new SqlConnection(@"Server=.\;" + "Database = Data_Personil; Integrated Security = true");
        }

    }
}
