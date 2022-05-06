using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Logger
{
    class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;
        }

        public override void Dispose()
        {
           
        }
    }
}
