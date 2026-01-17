using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Controller.Interfaces
{
    public interface ICustomerController
    {
        public void CreateCustomer(string firstName, string lastName, string email, string phone, string street, string zipcode, string city);
    }
}
