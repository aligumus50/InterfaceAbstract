﻿using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
