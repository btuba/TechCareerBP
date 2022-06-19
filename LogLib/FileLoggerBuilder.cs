using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    internal class FileLoggerBuilder : IFileLoggerBuilder
    {
        FileLogger fileLogger;

        public FileLoggerBuilder()
        {
            fileLogger = new();
        }
        public IFileLoggerBuilder SetTargetFormat(TargetFormat targetFormat)
        {
            fileLogger.targetFormat = targetFormat;
            return this;
        }

        public IFileLoggerBuilder SetTargetPath(string path)
        {
            fileLogger.Path = path;
            return this;
        }

        public Logger Create()
        {
            return fileLogger;
        }
    }

    internal enum TargetFormat
    {
        HTML,
        TEXT
    }
}
