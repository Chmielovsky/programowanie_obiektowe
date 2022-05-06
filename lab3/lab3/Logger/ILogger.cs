using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Logger
{
    public interface ILogger : IDisposable
    {
        void Log(params String[] messages);
    }
}
