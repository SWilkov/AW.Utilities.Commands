namespace AW.Utilities.Commands.Interfaces
{
  public interface ICommandResultHandler<T, U> 
    where T : class
    where U : class, ICommonResult
  {
    U Execute(T command);
  }
}
