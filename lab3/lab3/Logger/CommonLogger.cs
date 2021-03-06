using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Logger
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Log(params string[] messages)
        {
            foreach (var item in loggers)
            {
                item.Log(messages);
            }
        }

        public void Dispose()
        {
            foreach (var item in loggers)
            {
                item.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
