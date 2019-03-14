using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication166.Models;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = ApiClient.Post<CalculatorRequest, CalculatorResponse>(new CalculatorRequest { DigA = 5, DigB = 10, Action = "+" }, "http://localhost:2345/api/calculator/calculate");
            Console.WriteLine(obj.Result);
            Console.ReadKey();

        }
    }
}
