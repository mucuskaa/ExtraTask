using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment
{
    class TooYoungException : Exception
    {
        public byte Age { get; }
        public TooYoungException(string message, byte age)
            : base(message)
        {

        }
    }
}
