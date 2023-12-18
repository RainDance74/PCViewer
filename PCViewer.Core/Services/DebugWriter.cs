using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PCViewer.Core.Services
{
    public class DebugWriter
    {
        public void Write(string message)
        {
            Debug.Print($"{DateTime.Now} | {message}");
        }
    }
}
