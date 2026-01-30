using CManager.Application.Interfaces;
using CManager.Application.Validator;
using CManager.Domain.Factories;
using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Application.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public CustomerResult Add(CreateCustomerRequest request)
        {
            if (NameValidator.IsNotValid(request.FirstName))
            {
                return new CustomerResult(false, "Invalid first name");
            }
            if (!NameValidator.IsValid(request.LastName))
            {
                return new CustomerResult(false, "Invalid last name");
            }
            if (!EmailValidator.IsValid(request.Email))
            {
                return new CustomerResult(false, "Invalid email");
            }
            if (!PhoneValidator.IsValid(request.Phone))
            {
                return new CustomerResult(false, "Invalid phone");
            }

            
            if (_customerRepository.Exists(c => c.Email == request.Email))
            return new CustomerResult(false, "Email already in use");


            Customer customer = CustomerFactory.Create(request);

            var repositoryResult = _customerRepository.Add(customer);
            return repositoryResult;
        }

        public CustomerObjectResult<Customer> Get(Func<Customer, bool> predicate)
        {
            var repositoryObjectResult = _customerRepository.Get(predicate);
            return repositoryObjectResult;
        }

        public CustomerObjectResult<Customer> GetByEmail(string email)
        {
            var repositoryObjectResult = _customerRepository.GetByEmail(email);
            //To use with predicate
            //_customerRepository.Get(c => c.Email == email);
            return repositoryObjectResult;
        }

        public CustomerObjectResult<Customer> GetById(string id)
        {
            var repositoryObjectResult = _customerRepository.GetById(id);
            //To use with predicate
            //_customerRepository.Get(c => c.Id == id);
            return repositoryObjectResult;
        }
    }
}
