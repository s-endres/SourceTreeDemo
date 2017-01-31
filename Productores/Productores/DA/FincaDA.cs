using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Productores.BD;
using Productores.Logic;

namespace Productores.DA
{
    public class FincaDA
    {

        public static int Agregar(Finca pfinca)
        {
            int retorno = 0;
            using (SqlConnection conn = BDConnection.obtenerCnx())
            {
                SqlCommand comando = new SqlCommand(String.Format("Insert into Finca (nombre, area, id_productor) values ('{0}','{1}','{2}')",
                    pfinca.nombre, pfinca.area, pfinca.idProductor), conn);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Finca> BuscarTodos()
        {
            List<Finca> lFinca = new List<Finca>();
            using (SqlConnection conn = BDConnection.obtenerCnx())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * From Finca"), conn);

                System.Data.SqlClient.SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Finca finca = new Finca();
                    finca.id = Int32.Parse(reader["id"].ToString());
                    finca.nombre = reader["nombre"].ToString();
                    finca.area = Int32.Parse(reader["area"].ToString());
                    finca.idProductor = Int32.Parse(reader["id_productor"].ToString());

                    lFinca.Add(finca);
                }
            }
            return lFinca;
        }
    }
}