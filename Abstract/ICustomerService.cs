﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeDemo.Entitites;

namespace CoffeeDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
