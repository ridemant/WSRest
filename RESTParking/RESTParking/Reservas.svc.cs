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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Reservas" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Reservas.svc or Reservas.svc.cs at the Solution Explorer and start debugging.
    public class Reservas : IReservas
    {
        private ReservaDAO reservaDAO = new ReservaDAO();

        public Boolean CrearReserva(Reserva reserva)
        {
            return reservaDAO.Crear(reserva);
        }


    }
}
