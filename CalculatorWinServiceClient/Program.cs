using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorService_Proxy.Services;

namespace CalculatorWinServiceClient
{
  class Program
  {
    static void Main(string[] args)
    {
      CalculatorServiceSvcClient service = new CalculatorServiceSvcClient();
      Console.WriteLine(service.HeartBeat().ToString());

      double value1 = 100.00D;
      double value2 = 15.99D;
      double result = service.Add(value1, value2);
      Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

      // Call the Subtract service operation.
      value1 = 145.00D;
      value2 = 76.54D;
      result = service.Subtract(value1, value2);
      Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

      // Call the Multiply service operation.
      value1 = 9.00D;
      value2 = 81.25D;
      result = service.Multiply(value1, value2);
      Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

      // Call the Divide service operation.
      value1 = 22.00D;
      value2 = 7.00D;
      result = service.Divide(value1, value2);
      Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

      Console.ReadKey();
    }
  }
}
