public interface IUpdate<T, TResult>
{
    TResult Update(T request);
}
