using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    interface IState
    {
        int MoveUp(Context context);
        int MoveDown(Context context);
    }
}
