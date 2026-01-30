public interface IExists<T, TResult>
{
    TResult Exists(Func<T, bool> predicate);

}
