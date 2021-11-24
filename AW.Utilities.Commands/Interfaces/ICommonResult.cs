using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.Utilities.Commands.Interfaces
{
  public interface ICommonResult
  {
    dynamic Data { get; }
    int Rows { get; }
    string Message { get; }
    bool Success { get; }
  }
}
