using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                //Yorum satırını kaldırıp bilgilerinizi giriniz...

                /*DateOfBirth = new DateTime(YYYY,MM,DD), 
                FirstName = "FirstName",
                LastName = "LastName",
                NationalityId = "NationalityId"*/
            });
        }
    }
}
