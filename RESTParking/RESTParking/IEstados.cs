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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEstados" in both code and config file together.
    [ServiceContract]
    public interface IEstados
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "obtener", ResponseFormat = WebMessageFormat.Json)]
        Reservado ObtenerEstados();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "enviar", ResponseFormat = WebMessageFormat.Json)]
        Reservado EnviarEstado(Disponible disponible);

    }
}
