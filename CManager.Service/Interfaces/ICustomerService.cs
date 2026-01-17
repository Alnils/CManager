using CManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Service.Interfaces
{
    public interface ICustomerService
    {
        void Create(Customer customer);
    }
}
