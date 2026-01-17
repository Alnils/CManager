using CManager.Controller.Interfaces;
using CManager.Service.Interfaces;
using CManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Controller.Controllers
{
    internal class CustomerController : ICustomerController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void CreateCustomer( 
            string firstName, 
            string lastName, 
            string email, 
            string phone, 
            string street, 
            string zipcode, 
            string city
        )
        {
            var customer = new Customer 
            { 
                FirstName = firstName, 
                LastName = lastName, 
                Email = email, 
                Phone = phone, 
                Adress = new Adress 
                { 
                    Street = street, 
                    ZipCode = zipcode, 
                    City = city 
                } 
            };
            _customerService.Create(customer);
        }

    
    }
}
