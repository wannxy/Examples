using NDevHelper_V1.Handlers.LD;
using System;

namespace DevHelperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LDRangeControlHandler.TrendClock clock = new LDRangeControlHandler.TrendClock(10);
            clock.UpdateCounterInterval(5, 10);
            for (int i = 0; i < 100; i++)
            {
                if (i == 10)
                {
                    clock.LockedTo(10);
                }
                if (clock.Tick())
                {
                    Console.WriteLine(string.Format("{0} ->  {1}", i, clock.Value));
                }
                else
                {
                    Console.WriteLine("跳动失败！{0}",clock.Value);
                }
                if (i == 50)
                {
                    clock.UnLock();
                }
            }
        }

        private static void f1()
        {
            LDRangeControlHandler.TrendClock clock = new LDRangeControlHandler.TrendClock(100);
            int hit = 0;
            int miss = 0;
            for (int i = 0; i < 100_000_000; i++)
            {
                if (clock.Value == 1)
                {
                    hit++;
                }
                else
                {
                    miss++;
                }
            }
            Console.WriteLine(string.Format("命中: {0}, 未命中: {1}, 总计: {2},命中比例: {3}", hit, miss, hit + miss, hit / (float)(hit + miss)));
        }
    }
}
