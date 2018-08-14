using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Blitz_Reader.Models;

namespace WPF_Blitz_Reader.Service
{
    class FileService
    {
        public List<LogModel> ReadLog(string LogFilePath)
        {
            List<LogModel> LogFile = new List<LogModel>();

            string[] LogMessages = System.IO.File.ReadAllLines(LogFilePath);

            foreach(string s in LogMessages)
            {
                string[] parts = s.Split(',');

                DateTime TimeStamp = Convert.ToDateTime(parts[0]);
                string CurrentStage = parts[1];
                string LogLevel = parts[2];
                string LogData = parts[3];

                LogFile.Add(new LogModel(TimeStamp, CurrentStage, LogLevel, LogData));
            }

            return LogFile;
        }
    }
}
