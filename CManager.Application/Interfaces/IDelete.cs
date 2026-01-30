public interface IDelete<T, TResult>
{
    TResult Delete(T id);
}
