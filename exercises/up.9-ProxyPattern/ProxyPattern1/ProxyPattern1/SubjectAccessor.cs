using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern1
{
    class SubjectAccessor
    {
        public interface ISubject
        {
            string Request();
        }
        private class Subject : ISubject
        {
            public string Request()
            {
                return "Subject Request " + "Choose door 503 \n";
            }
        }

        public class Proxy : ISubject
        {
            Subject subject;

            public string Request()
            {
                // A virtual proxy creates the object only on its first method call
                if (subject == null)
                {
                    Console.WriteLine("Subject inactive");
                    subject = new Subject();
                }
                Console.WriteLine("Subject active");
                return "Proxy: Call to " + subject.Request();
            }
        }

        public class ProtectionProxy : ISubject
        {
            // An authentication proxy first asks for a password
            Subject subject;
            string password = "Abracadabra";

            public string Authenticate(string supplied)
            {
                if (supplied != password)
                    return "Protection Proxy: No access";
                else
                    subject = new Subject();
                return "Protection Proxy: Authenticated";
            }

            public string Request()
            {
                if (subject == null)
                    return "Protection Proxy: Authenticate first";
                else return "Protection Proxy: Call to " + subject.Request();
            }
        }
    }
}
