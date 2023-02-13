using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class EmptyBandException : Exception
    {
        public string BandName { get; }

        public EmptyBandException() { }
        public EmptyBandException(string message)
        : base(message) { }

        public EmptyBandException(string message, string bandName)
        : this(message)
        {
            BandName = bandName;
        }
    }
}
}
