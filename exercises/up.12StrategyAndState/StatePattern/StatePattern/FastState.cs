using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    // State 2
    class FastState : IState
    {
        public int MoveUp(Context context)
        {
            context.Counter += 5;
            return context.Counter;
        }


        public int MoveDown(Context context)
        {
            if (context.Counter < Context.limit)
            {
                context.State = new NormalState();
                Console.Write("|NS|");
            }
            context.Counter -= 5;
            return context.Counter;
        }
    }
}