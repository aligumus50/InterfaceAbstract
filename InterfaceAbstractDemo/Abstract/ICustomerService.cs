using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    interface ICustomerService
    {
        void Save(Customer customer);
    }
}
