using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Blitz_Reader.Models
{
    class LogModel
    {
        public DateTime TimeStamp { get; set; }
        public String Stage { get; set; }
        public String Level { get; set; }
        public String Message { get; set; }


        public LogModel(DateTime TimeStamp, String Stage, String Level, String Message)
        {
            this.TimeStamp = TimeStamp;
            this.Stage = Stage;
            this.Level = Level;
            this.Message = Message;
        }
    }
}
