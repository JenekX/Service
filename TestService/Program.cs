using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TestService.ServiceReference1;

namespace TestService
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();

            Console.WriteLine(client.Add(10, 20));
            Console.ReadKey();

            client.Close();
        }
    }
}
