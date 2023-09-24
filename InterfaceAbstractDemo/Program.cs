using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entity;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo 
{
    class Program
    {
        static void Main(string[] args) 
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { DateOfBirth = new DateTime(1990,5,2),
                                                    FirstName="Kaan", LastName="Derin",
                                                    NationalityId="12345678910"});
            Console.ReadLine();
        }
    }
}
