using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string test1 = ;
            //var test2 = "権兵衛";
            Object obj = 100;
            switch(obj)
            {
                #region case文書きまくり
                case int i when i >= 70:
                    Console.WriteLine("優");
                    break;
                case int i:
                    Console.WriteLine("数値です");
                    break;
                default:
                    Console.WriteLine("意図しない型です");
                    break;
                #endregion
            }

        }
    }
}
