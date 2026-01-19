using CManager.Application.Interfaces;
using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CManager.Infrastructure
{
    internal class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            var customers = new List<Customer>();
            customers.Add(customer);
            var json = JsonSerializer.Serialize(customers);
            File.WriteAllText("customers.json", json);
        }
    }
}
