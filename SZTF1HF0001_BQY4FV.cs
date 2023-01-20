using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1HF0001_BQY4FV
{
    class SZTF1HF0001_BQY4FV
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            long divsum = 0;

            for (int i = 1; i <= n; ++i)
            {
                divsum += (n / i) * i;
            }

            Console.WriteLine("1-" + n + "-ig a számok osztóinak összege: " + divsum + ".");

            Console.ReadLine();


        }


    }
}
