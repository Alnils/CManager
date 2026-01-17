using CManager.Service.Interfaces;
using CManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CManager.Repository.Json.Repositories
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
