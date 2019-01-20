using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleConsumer.ServiceReference1;
using System.Net;

namespace ConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1SoapClient service = new ServiceReference1.Service1SoapClient();

            Console.WriteLine(service.Fibonacci(10));
            Console.ReadKey();
        }
    }
}
