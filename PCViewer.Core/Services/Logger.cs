using PCViewer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PCViewer.Core.Services
{
    public class Logger : ILogger
    {
        public event Action<string> OnLog;
        public void Log(string message)
        {
            OnLog?.Invoke(message);
        }
    }
}
