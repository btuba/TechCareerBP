using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    internal class Settings
    {
        internal string connectionString { get; set; }
        internal string targetPath { get; set; }
        internal TargetFormat targetFormat { get; set; }
        internal DB targetDB { get; set; }
        internal LogType logType { get; set; }
    }
    internal enum LogType
    {
        File,
        Db
    }
}
