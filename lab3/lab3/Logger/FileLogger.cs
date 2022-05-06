using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab3.Logger
{

    class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Append);
            base.writer = new StreamWriter(stream, Encoding.UTF8);
        }

        public override void Dispose()
        {
            base.writer.Dispose();
            this.stream.Dispose();
        }
    }
}
