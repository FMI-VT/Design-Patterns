using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern1
{
    class Client : SubjectAccessor
    {
        static void Main()
        {
            Console.WriteLine("Proxy Pattern\n");
            Console.WriteLine("=============\n");

            ISubject subject = new Proxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());
            Console.WriteLine("=============\n");

            ProtectionProxy subjectProtected = new ProtectionProxy();
            Console.WriteLine(subjectProtected.Request());
            //Console.WriteLine((subjectProtected as ProtectionProxy).Authenticate("Secret"));
            //Console.WriteLine((subjectProtected as ProtectionProxy).Authenticate("Abracadabra"));
            Console.WriteLine(subjectProtected.Authenticate("Secret"));
            Console.WriteLine(subjectProtected.Authenticate("Abracadabra"));
            Console.WriteLine(subjectProtected.Request());

            // ISubject test = new Subject(); //The logic of the program is organized, that the Client can only declare proxies!!!
        }
    }
}
