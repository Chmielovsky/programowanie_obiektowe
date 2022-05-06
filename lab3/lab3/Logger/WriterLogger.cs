using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab3.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            DateTime time = DateTime.Now;
            writer.WriteLine(time.ToString("yyyy-MM-ddTHH:mm:sszzz") + ": " + String.Join(" ", messages));
            writer.Flush();
        }

        public abstract void Dispose();
    }
}
