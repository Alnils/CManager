using CManager.Application.Interfaces;
using CManager.Domain.Models;
using CManager.Infrastructure.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CManager.Infrastructure.Repositories
{
    public sealed class FileStorageRepository(string filePath) : ICustomerRepository
    {

        private readonly string _filePath = filePath;

        public CustomerResult Add(IEnumerable<Customer> request)
        {
            try
            {
                var json = JsonDataFormatter.Serialize(request);

                File.WriteAllText(_filePath, json);

                return new CustomerResult(true, "Saved");
            }
            catch (Exception ex)
            {
                return new CustomerResult(true, "Could not save");
            }
        }



        public bool Exists(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public CustomerObjectResult<IEnumerable<Customer>> Get(Func<Customer, bool> predicate)
        {
            try
            {
                var json = File.ReadAllText(_filePath);

                var customers = JsonDataFormatter.Deserialize<IEnumerable<Customer>>(json);

                return new CustomerObjectResult<IEnumerable<Customer>>(true, "", customers);
            }
            catch (Exception ex)
            {
                return new CustomerObjectResult<IEnumerable<Customer>>(false, ex.Message, []);
            }
        }

        public CustomerObjectResult<Customer> Get(Func<IEnumerable<Customer>, bool> predicate)
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
    }
}
