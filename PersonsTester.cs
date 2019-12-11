using System;
using System.Collections;

namespace Enumerables
{
    class PersonsTester
    {
        public static void Main(string[] args)
        {
            string[] stringArray = new string[]{"test1", "test2", "test3", "test4"};
            var test = stringArray.GetEnumerator();
            while(test.MoveNext())
            {
                Console.WriteLine(test.Current);
            }
        }
    }
}
