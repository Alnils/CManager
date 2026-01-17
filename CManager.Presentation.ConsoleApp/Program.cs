var repository = new CManager.Repository.Json.DependenciesInjection().GetCustomerRepository();
var service = new CManager.Service.DependenciesInjection().GetCustomerService(repository);
var controller = new CManager.Controller.DependenciesInjection().GetCustomerController(service);

controller.CreateCustomer(
    "John",
    "Deer",
    "john.deer@mail.com",
    "1234567890",
    "123 Main St",
    "12345",
    "Anytown"
    );