using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Productores.Logic;
using Productores.BD;

namespace Productores.DA
{
    public class ProductorDA
    {
        public static int Agregar(Productor pproductor)
        {
            int retorno = 0;
            using (SqlConnection conn = BDConnection.obtenerCnx())
            {
                SqlCommand comando = new SqlCommand(String.Format("Insert into Productor (id, nombre, telefono, email) values ('{0}','{1}','{2}','{3}')",
                    pproductor.id, pproductor.nombre, pproductor.telefono, pproductor.email), conn);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Productor> BuscarTodos()
        {
            List<Productor> lProductor = new List<Productor>();
            using (SqlConnection conn = BDConnection.obtenerCnx())
            {
                SqlCommand comando = new SqlCommand(String.Format("Select * From Productor"), conn);

                System.Data.SqlClient.SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Productor productor = new Productor();
                    productor.id = Int32.Parse(reader["id"].ToString());
                    productor.nombre = reader["nombre"].ToString();
                    productor.telefono = reader["telefono"].ToString();
                    productor.email = reader["email"].ToString();
                    productor.fincas = Int32.Parse(reader["fincas"].ToString());

                    lProductor.Add(productor);
                }
            }
            return lProductor;
        }
    }
}