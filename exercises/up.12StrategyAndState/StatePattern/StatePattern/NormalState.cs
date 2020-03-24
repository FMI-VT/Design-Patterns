using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    // State 1
    class NormalState : IState
    {
        public int MoveUp(Context context)
        {
            context.Counter += 2;
            return context.Counter;
        }

        public int MoveDown(Context context)
        {
            if (context.Counter < Context.limit)
            {
                context.State = new FastState();
                Console.Write("|FS| ");
            }
            context.Counter -= 2;
            return context.Counter;
        }
    }
}
