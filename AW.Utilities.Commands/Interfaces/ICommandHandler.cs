namespace AW.Utilities.Commands.Interfaces
{
  public interface ICommandHandler<T> where T : class
  {
    void Execute(T command);
  }
}
