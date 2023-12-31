﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }


        /*
        private void CheckIfRealPerson(Customer customer)
        {
            //Buraya tüm kodu yazabiliriz, fakat ilerleyen süreçlerde nero'da kontrol edilmesini isterse diye metodu abstract içerisinde oluşturduğumuz class içerisine yazıyoruz.

        }
        */


    }
}
