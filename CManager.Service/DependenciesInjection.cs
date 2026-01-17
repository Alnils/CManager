using CManager.Service.Interfaces;

namespace CManager.Service
{
    public class DependenciesInjection
    {
        public ICustomerService GetCustomerService(ICustomerRepository customerRepository) {
            var customerService = new Services.CustomerService(customerRepository);
            return customerService;
        }
    }
}