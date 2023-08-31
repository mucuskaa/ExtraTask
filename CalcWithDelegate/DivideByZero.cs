using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWithDelegate
{
    internal class DivideByZero
    {

        public static event EventHandler DivideByZeroEvent = null;

        public static void EventInvoke()
        {
            DivideByZeroEvent.Invoke(null, EventArgs.Empty);
        }

    }
}
