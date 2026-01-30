public interface IGet<T, TResult>
{
    TResult Get(Func<T, bool> predicate);

}
