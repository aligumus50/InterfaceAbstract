﻿using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            //basedeki save metodunu ezdik.

            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            else
            {
                throw new Exception("Not a valid person");
            }
            
            
        }

        
    }
}
