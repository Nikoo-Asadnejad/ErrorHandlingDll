using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingDll.Services
{
  public interface ILoggerService
  {
    Task CaptureLogAsync(LogLevel level,string message, Dictionary<string, string> tags = null);
    Task CaptureLogAsync(LogLevel level, Exception exception , string message = null, Dictionary<string,string> tags = null);
  }
}
