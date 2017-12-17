using RESTParking.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTParking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReservas" in both code and config file together.
    [ServiceContract]
    public interface IReservas
    {

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "reserva", ResponseFormat = WebMessageFormat.Json)]
        Boolean CrearReserva(Reserva reserva);


    }
}
