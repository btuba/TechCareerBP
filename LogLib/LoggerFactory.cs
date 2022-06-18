using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public class LoggerFactory
    {
        private string connectionString;
        private string targetPath;
        private TargetFormat targetFormat;
        private DB targetDB;
        private LogType logType;

        public LoggerFactory(string configFile, Format fileFormat)
        {
            switch (fileFormat)
            {
                case Format.XML:
                    ReadFromXML();
                    break;
                case Format.JSON:
                    ReadFromJSON();
                    break;
                default:
                    throw new Exception();
            }
        }
        public Logger CreateLogger()
        {
            switch (logType)
            {
                case LogType.File:
                    return new FileLogger(targetPath, targetFormat);
                case LogType.Db:
                    switch (targetDB)
                    {
                        case DB.ORACLE:
                            return new OracleDBLogger(connectionString);
                        case DB.MSSQL:
                            return new MSSqlDBLogger(connectionString);
                    }
                    throw new Exception();
            }
            throw new Exception();
        }

        private void ReadFromXML()
        {

        }

        private void ReadFromJSON()
        {

        }

        private enum LogType
        {
            File,
            Db
        }

        private enum DB
        {
            ORACLE,
            MSSQL
        }
    }

    public enum Format
    {
        XML,
        JSON
    }

    public enum TargetFormat
    {
        HTML,
        TEXT
    }
}
