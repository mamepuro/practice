using System;
using System.Collections;
using System.Collections.Generic;
namespace test
{
    public class Fibonacci : IEnumerable<int>
    {
        private int _number;
        private int _fib1;
        private int _fib2;
        public Fibonacci(int number)
        {
            _number = number;
            _fib1 = 0;
            _fib2 = 1;
        }
        public IEnumerator<int> GetEnumerator()
        {
            if (_number < 0)
            {
                Console.WriteLine("0以上の数値を入力してください。");
                yield break;
            }
            for (var count = 0; count <= _number; count++)
            {
                if (count == 0 || count == 1)
                {
                    yield return count;
                }
                else
                {
                    int temp = _fib1 + _fib2;
                    yield return temp;
                    _fib1 = _fib2;
                    _fib2 = temp;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
