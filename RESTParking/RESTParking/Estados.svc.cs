using RESTParking.Dominio;
using RESTParking.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTParking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Estados" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Estados.svc or Estados.svc.cs at the Solution Explorer and start debugging.
    public class Estados : IEstados
    {

        EstadoDAO estadoDAO = new EstadoDAO();

        public Reservado ObtenerEstados()
        {

            return estadoDAO.Obtener();

        }


        public Reservado EnviarEstado(Disponible disponible)
        {
            return estadoDAO.Enviar(disponible);
        }



    }
}
