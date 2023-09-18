using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*****************************************************************************************
            /* 
             * Bu iki kodun çıktısı aynı
             *Bu durumda interfacelerde o interface'i implement eden class'ın referansını tutabiliyor.

            ---------------------------------------------------
            PersonalCreditManager personalCreditManager = new PersonalCreditManager();
            personalCreditManager.Calculate();

            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            vehicleCreditManager.Calculate();

            HousingCreditManager housingCreditManager = new HousingCreditManager();
            housingCreditManager.Calculate();
            ---------------------------------------------------
            ICreditManager personalCreditManager = new PersonalCreditManager();
            personalCreditManager.Calculate();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            vehicleCreditManager.Calculate();

            ICreditManager housingCreditManager = new HousingCreditManager();
            housingCreditManager.Calculate();

            */

            //*****************************************************************************************


            //Not: Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

            //*****************************************************************************************




            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService= new DatabaseLoggerService();
            ILoggerService fileLoggerService= new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(personalCreditManager, databaseLoggerService); //yazılımda sürsürülebilirliği sağlar




            //*****************************************************************************************


            List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager,vehicleCreditManager};
            //applicationManager.CreditPreInforming(credits);


            //*****************************************************************************************

            /*Not: SOLID
                   0 -> Sisteme yeni bir kod eklendiğinde sistem bozulmaz.
            */
        }
    }
}
