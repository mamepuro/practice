using System;
using System.Collections;
using System.Collections.Generic;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var f_list = new Prime(50);
            foreach (var value in f_list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
