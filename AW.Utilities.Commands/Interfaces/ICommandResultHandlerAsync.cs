namespace AW.Utilities.Commands.Interfaces
{
  public interface ICommandResultHandlerAsync<T, U>
    where T : class
    where U : class, ICommonResult
  {
    Task<U> ExecuteAsync(T command);
  }
}
