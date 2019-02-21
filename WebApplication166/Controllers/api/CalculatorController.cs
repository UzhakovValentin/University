using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication166.Models;

namespace WebApplication166.Controllers.api
{
    public class CalculatorController : ApiController
    {
        [HttpPost]
        public CalculatorResponse Calculate
                            (CalculatorRequest request)
        {
            decimal result;

            switch (request.Action)
            {
                case "+":
                    result = request.DigA + request.DigB;
                    break;
                case "-":
                    result = request.DigA - request.DigB;
                    break;
                case "*":
                    result = request.DigA * request.DigB;
                    break;
                case "/":
                    result = request.DigA / request.DigB;
                    break;
                case "^":
                    result = Pow(request.DigA, request.DigB);
                    break;
                default:
                    throw new InvalidOperationException();
            }

            return new CalculatorResponse { Result = result };
        }

        private decimal Pow(decimal a, decimal b)
        {
            decimal temp = 1;
            for (int i = 0; i < b; i++)
            {
                temp *= a;
            }
            return temp;
        }
    }
}