using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFCalcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new CalcService.CalcServiceClient())
            {
                double test = client.Minus(10, 9);

                Console.WriteLine(test);
            }
            Console.ReadLine();
        }
    }
}
