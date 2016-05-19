using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           var sample = "I enjoy yikes and nope";

            var result = from c in sample
                         select c;
            //write each letter one per line
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //ascending order
            var result1 = from c in sample
                          where c == 'a' || c == 'e' || c == 'i' || c == 'o' ||
                          c == 'u'
                          group c by c;

                                    
            //write each letter one per line
            foreach (var item in result1)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("{0} - {1}", item.Key, item.Count());
            }

        }
    }
}
