using CManager.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Repository.Json
{
    public class DependenciesInjection
    {
        public ICustomerRepository GetCustomerRepository()
        {
            var customerRepository = new Repositories.CustomerRepository();
            return customerRepository;
        }
    }
}
