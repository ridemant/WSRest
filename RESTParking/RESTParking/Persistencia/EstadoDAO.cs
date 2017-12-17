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
    public class EstadoDAO
    {


        public Reservado Obtener()
        {
            List<int> listaReservas = new List<int>();

            listaReservas.Add(0);
            listaReservas.Add(2);

            Reservado resv = new Reservado();
            resv.total = 2;
            resv.reservados = listaReservas;

            return resv;
        }



        public Reservado Enviar(Disponible disponible)
        {


            using (SqlConnection conexion = new SqlConnection(Config.CAD_CONEXION)){
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("update estado_estacionamiento set sta_fecha=SYSDATETIME(), sta_condicion='3'", conexion)){
                    comando.ExecuteNonQuery();
                }
            }

            if (disponible.total > 0)
            foreach (int id in disponible.disponibles)
            {
                string sql = "update estado_estacionamiento set sta_fecha=SYSDATETIME(), sta_condicion='1' where sta_estado = @id";
                using (SqlConnection conexion = new SqlConnection(Config.CAD_CONEXION)){
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql, conexion)){
                        comando.Parameters.Add(new SqlParameter("@id", id+1)); 
                        comando.ExecuteNonQuery();
                    }
                }
            }



            List<int> listaReservas = new List<int>();
            int c = 0;
 
            string sql1 = "select * from estado_estacionamiento where sta_condicion = 2";
            using (SqlConnection conexion = new SqlConnection(Config.CAD_CONEXION))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql1, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            int e = (int)resultado["sta_estado"];
                            listaReservas.Add(e);
                            c++;
                        }
                    }
                }
            }

            return new Reservado() { total = c, reservados = listaReservas};
        }
    }
}