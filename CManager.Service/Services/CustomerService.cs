using CManager.Service.Interfaces;
using CManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Service.Services
{
    internal class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void Create(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }
    }
}
