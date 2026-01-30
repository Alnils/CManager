using CManager.Application.Interfaces;
using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CManager.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerResult Add(IEnumerable<Customer> request)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(Customer customer)
        {
            var customers = new List<Customer>();
            customers.Add(customer);
            var json = JsonSerializer.Serialize(customers);
            File.WriteAllText("customers.json", json);
        }

        public CustomerResult Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public CustomerObjectResult<Customer> Get(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public CustomerObjectResult<IEnumerable<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerObjectResult<Customer> GetByEmail(string id)
        {
            throw new NotImplementedException();
        }

        public CustomerObjectResult<Customer> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public CustomerResult Update(Customer request)
        {
            throw new NotImplementedException();
        }
    }
}
