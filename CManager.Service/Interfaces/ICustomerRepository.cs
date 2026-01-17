using CManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Service.Interfaces
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
    }
}
