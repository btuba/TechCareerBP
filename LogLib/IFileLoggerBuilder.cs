using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    internal interface IFileLoggerBuilder
    {
        IFileLoggerBuilder SetTargetPath(string path);
        IFileLoggerBuilder SetTargetFormat(TargetFormat targetFormat);
        Logger Create();
    }
}
