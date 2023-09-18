using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Başvuru Manager
    class ApplicationManager
    {
        //method Injection
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme

            /*Tüm başvuruları konut kredisine bağlı hale getirdik. Bu  doğru olmaz.
             * Bu sebeple başvuru yaparken bir parametre alsak ve bu parametre ile hangi krediye göre yapmamız gerektiğini söylersek problemi çözmüş oluruz 
             * 
            HousingCreditManager housingCreditManager = new HousingCreditManager();
            housingCreditManager.Calculate();
            */


            //Bu kod ile başvuruyu kredi bağımsız hale getirmiş olur. 
            creditManager.Calculate();

            //Hangi logger service gönderilmişse onu logla
            loggerService.Log();
        }



        //Kredi Ön Bilgilendirme Yap
        //Bir tanede olabilir bir birden fazlada olabilir, bu sebeple List<> olarak tanımlarız
        public void CreditPreInforming(List<ICreditManager> credits)
        {
            //Listedeki her bir kredinin hesabını yap
            foreach(var credit in credits)
            {
                credit.Calculate();
            }


        }



        //Bu metodu aynı zamanda loglamak istersek metot içerisinde (ILoggerService loggerService) ekleriz

    }
}
