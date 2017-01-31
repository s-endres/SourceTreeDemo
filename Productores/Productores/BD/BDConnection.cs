using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Productores.BD
{
    public class BDConnection
    {
        public static SqlConnection obtenerCnx()
        {
            SqlConnection sqlcnx = new SqlConnection(
                "Data source=SFEC\\SQLEXPRESS; Initial Catalog=Cafinter; Integrated Security=SSPI"); /*Este es con windows authentication*/
            /*Data source=SFEC\\SQLEXPRESS; Initial Catalog=MyContacts; User id=SFEC/Stephan; Password="*/
            /*Este es con usuario y contrasenna*/
            sqlcnx.Open();
            return sqlcnx;
        }

    }
}