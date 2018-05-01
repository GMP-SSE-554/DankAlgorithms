using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankAlgorithms.Algorithms
{
    public class ProgressEvent: EventArgs
    {
        private Exception error;
        private int progress;

        public ProgressEvent(Exception ex, int msg)
        {
            error = ex;
            progress = msg;
        }

        public Exception Error
        {
            get { return error; }
        }

        public int Progress
        {
            get { return progress; }
        }
    }
}
