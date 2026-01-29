using CManager.Domain.Models;

public interface ICustomerService : 
    IAdd<CreateCustomerRequest, CustomerResult>,
    IGet<Customer, CustomerObjectResult<Customer>>,
    IGetById<string, CustomerObjectResult<Customer>>, 
    IGetByEmail<string, CustomerObjectResult<Customer>>

{


}

public interface IAdd<T , TResult>
{ 
    TResult Add(T request);

}

public interface IGet<T, TResult>
{
    TResult Get(Func<T, bool> predicate);

}

public interface IGetById<T, TResult>
{
    TResult GetById(T id);

}

public interface IGetByEmail<T, TResult>
{
    TResult GetByEmail(T id);

}

public interface IExists<T, TResult>
{
    TResult Exists(Func<T, bool> predicate);

}
