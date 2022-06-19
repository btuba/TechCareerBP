using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public class LoggerFactory
    {
        Settings settings;

        public LoggerFactory(string configFile, Format fileFormat)
        {
            switch (fileFormat)
            {
                case Format.XML:
                    settings = new XMLSerializer().Serialize(configFile);
                    break;
                case Format.JSON:
                    settings = new JSONSerializer().Serialize(configFile);
                    break;
                default:
                    throw new Exception();
            }
        }
        public Logger CreateLogger()
        {
            switch (settings.logType)
            {
                case LogType.File:
                    return  new FileLoggerBuilder().SetTargetFormat(settings.targetFormat)
                        .SetTargetPath(settings.targetPath).Create();
                case LogType.Db:
                     return new ConnectableLoggerBuilder().SetConectionString(settings.connectionString)
                    .SetDb(settings.targetDB).Create();
            }
            throw new Exception();
        }
    }

    public enum Format
    {
        XML,
        JSON
    }
}
