using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWithDelegate
{
    public delegate void EventDivideByZero();
    internal class DivideByZero
    {

        public event EventDivideByZero DivideByZeroEvent = null;

        public void EventInvoke()
        {
            DivideByZeroEvent.Invoke();
        }

    }
}
