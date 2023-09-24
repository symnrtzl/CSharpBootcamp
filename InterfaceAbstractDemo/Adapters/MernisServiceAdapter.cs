using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
                                                      customer.FirstName.ToUpper(),
                                                      customer.LastName.ToUpper(),
                                                      customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
