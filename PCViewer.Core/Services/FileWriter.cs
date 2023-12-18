using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PCViewer.Core.Services
{
    public class FileWriter
    {
        private const string FILE_NAME = "logs.txt";
        public void Write(string message)
        {
            using(StreamWriter writer = new StreamWriter(FILE_NAME, true))
            {
                writer.WriteLine($"{DateTime.Now} | {message}");
            }
        }
    }
}
