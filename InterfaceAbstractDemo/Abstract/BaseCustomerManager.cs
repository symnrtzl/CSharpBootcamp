using InterfaceAbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstName);
        }

        //Burada virtual diyerek bu metodun ezilebileceğini gösterir. Starbuck'ta müşterileri kaydederken mernis istemesi ile alakalı olarak bu metodu güncellemiş olduk.


    }
}
