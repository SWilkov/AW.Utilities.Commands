namespace AW.Utilities.Commands.Interfaces
{
  public interface ICommandHandlerAsync<T> where T : class
  {
    Task ExecuteAsync(T command);
  }
}
