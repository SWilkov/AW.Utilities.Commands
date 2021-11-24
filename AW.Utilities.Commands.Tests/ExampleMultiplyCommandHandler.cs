using AW.Utilities.Commands.Interfaces;
using System;
using Xunit;

namespace AW.Utilities.Commands.Tests
{
  public class MultiplyCommand
  {
    public int X { get; }
    public int Y { get; }
    public MultiplyCommand(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }
  }

  public class MyResult : ICommonResult
  {
    public dynamic Data { get; private set; }

    public int Rows { get; private set; }

    public string Message { get; private set; }

    public bool Success { get; private set; }
    public MyResult(dynamic data, int rows = 0, string message = "", bool success = true)
    {
      this.Data = data;
      this.Message = message;
      this.Rows = rows;
      this.Success = success;
    }
  }

  public class MultiplyCommandHandler : ICommandResultHandler<MultiplyCommand, MyResult>
  {
    public MyResult Execute(MultiplyCommand command)
    {
      if (command == null) throw new ArgumentNullException(nameof(command));

      var multiplied = command.X * command.Y;
      var result = new MyResult(multiplied);

      return result;
    }
  }

  public class ExampleMultiplyCommandHandler
  {
    private ICommandResultHandler<MultiplyCommand, MyResult> _handler;
    public ExampleMultiplyCommandHandler()
    {
      _handler = new MultiplyCommandHandler();
    }

    [Fact]
    public void Test1()
    {
      var cmd = new MultiplyCommand(20, 30);
      var result = _handler.Execute(cmd);
      Assert.NotNull(result);
      Assert.IsType<MyResult>(result);
      Assert.Equal(600, result.Data);
    }
  }
}