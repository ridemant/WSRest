using RESTParking.Dominio;
using RESTParking.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace RESTParking.Persistencia
{
    public class ReservaDAO
    {

        public Boolean Crear(Reserva scs)
        {


            Debug.WriteLine(scs);

            Boolean creado = false;
            string sql = "update estado_estacionamiento set sta_estado=@estacionamientoid, sta_fecha=@fecha, sta_condicion=@condicion where sta_id = @id";
            using (SqlConnection conexion = new SqlConnection(Config.CAD_CONEXION))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", scs.id));
                    comando.Parameters.Add(new SqlParameter("@estacionamientoid", scs.estacionamiento_id));
                    comando.Parameters.Add(new SqlParameter("@fecha", scs.fecha));
                    comando.Parameters.Add(new SqlParameter("@condicion", scs.estado));
                    comando.ExecuteNonQuery();
                    creado = true;
                }

            }

            return creado;
        }


    }
}