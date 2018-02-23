using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSTCPListener
{
    class Log
    {
        public StreamWriter sw = null;
        private string log = "";
        public bool IsClosed = false;
        public Log(string path)
        {
            sw = new StreamWriter(path, true);
        }
        public void Add(DateTime timestamp, string message)
        {
            log += timestamp.ToString() + ":\t" + message + "\n";
        }
        public void Save()
        {
            sw.WriteLine(log);
            sw.Flush();
        }
        public void Close()
        {
            sw.Close();
            IsClosed = true;
        }
    }
}
