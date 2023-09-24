using GameSalesDemo.Abstract;
using GameSalesDemo.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace GameSalesDemo.Adapters
{
    internal class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId),
                                                      gamer.FirstName.ToUpper(),
                                                      gamer.LastName.ToUpper(),
                                                      gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }


    }
}
