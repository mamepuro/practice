using System;
using System.Collections;
using System.Collections.Generic;

namespace test
{
    public class Prime:IEnumerable<int>
    {
        private int _num;
        private int _minNum;//最小の素数
        public Prime(int num)
        {
            _num = num;
            _minNum = 2;
        }
        public bool IsPrime(int num)
        {
            for(int i=_minNum;i<=Math.Sqrt(num);i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public IEnumerator<int> GetEnumerator()
        {
            if (_num < _minNum)
            {
                Console.WriteLine("素数の最小値、2以上の数値を引数として代入してください。");
                yield break;
            }
            for(int num = _minNum;num<=_num;num++)
            {
                if(IsPrime(num))
                {
                    yield return num;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
