using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1496
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.In.ReadToEnd().Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var res = values
      .GroupBy(n => n, (n, m) => new { Key = n, Cnt = m.Count() })
      .Where(n => n.Cnt > 1)
      .Select(n => n.Key)
      .ToArray();
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();//лляля
            ///wooow
        }
    }
}
