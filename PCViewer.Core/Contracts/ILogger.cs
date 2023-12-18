using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Contracts
{
    public interface ILogger
    {
        event Action<string> OnLog;
        void Log(string message);
    }
}
