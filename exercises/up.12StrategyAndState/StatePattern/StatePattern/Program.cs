using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    // Shows two states with two operations, which themselves change the state
    // Increments and decrements a counter in the context
    class Program
    {
        // The user interface
        static void Main(string[] args)
        {
            Context context = new Context();
            context.State = new NormalState();
            Random r = new Random(37);
            for (int i = 5; i <= 25; i++)
            {
                int command = r.Next(3);
                Console.Write(context.Request(command) + " ");
            }
            Console.WriteLine();
        }
    }
}
