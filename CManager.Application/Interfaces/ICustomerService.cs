using CManager.Domain.Models;





public interface ICustomerService :
    IAdd<CreateCustomerRequest, CustomerResult>,
    IGet<Customer, CustomerObjectResult<Customer>>,
    IGetById<string, CustomerObjectResult<Customer>>,
    IGetByEmail<string, CustomerObjectResult<Customer>>,
    IGetAll<CustomerObjectResult<IEnumerable<Customer>>>,
    IExists<Customer, bool>,
    IUpdate<Customer, CustomerResult>,
    IDelete<string, CustomerResult>;