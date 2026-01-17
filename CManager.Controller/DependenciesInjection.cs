using CManager.Controller.Interfaces;
using CManager.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Controller
{
    public class DependenciesInjection
    {
        public ICustomerController GetCustomerController(ICustomerService customerService)
        {

            var customerController = new CManager.Controller.Controllers.CustomerController(customerService);
            return customerController;
        }
    }


}
