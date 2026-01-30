public interface IGetById<T, TResult>
{
    TResult GetById(T id);

}
