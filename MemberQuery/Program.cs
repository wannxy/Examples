using NDevHelper_V1.Net.Back2Api;
using NDevHelper_V1.Net.Client;
using System;
using System.Collections.Generic;

namespace MemberQuery
{
    class Program
    {
        static Back2Client back2 = new Back2Client("2CEF7A7D7FE8B441F6038FF6307937E0", "Back2");
        static void Main(string[] args)
        {
            InitMember();

            zombie();
        }

        /// <summary>
        /// 羊毛党
        /// 1: 无充值订单
        /// 2: 资金明细内只有手机运动收益
        /// </summary>
        private static void wool()
        {

        }


        /// <summary>
        /// 检查僵尸号<br/>
        /// 1: 注册时间为15天的账号<br/>
        /// 2: 3账号资产全部为0<br/>
        /// 3: 资金明细一个月内未任何记录<br/>
        /// </summary>
        private static void zombie()
        {
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime before15 = today.AddDays(-15);
            DateTime before30 = today.AddMonths(-1);
            List<__Member__.Result.cell> authorZombie = new List<__Member__.Result.cell>(3000);
            List<__Member__.Result.cell> unauthorZombie = new List<__Member__.Result.cell>(2000);
            foreach (var item in authorized)
            {
                if (item.registerTime < before15 &&
                    item.aci == 0 && item.mineAci == 0 && item.contractAci == 0 &&
                    item.asi == 0 && item.mineAsi == 0 && item.contractAsi == 0 &&
                    item.usdt == 0 && item.mineUsdt == 0 && item.contractUsdt == 0)
                {
                    authorZombie.Add(item);// 符合第一/二 条件已授权
                }
            }
            foreach (var item in unauthorized)
            {
                if (item.registerTime < before15 &&
                    item.aci == 0 && item.mineAci == 0 && item.contractAci == 0 &&
                    item.asi == 0 && item.mineAsi == 0 && item.contractAsi == 0 &&
                    item.usdt == 0 && item.mineUsdt == 0 && item.contractUsdt == 0)
                {
                    unauthorZombie.Add(item);// 符合第一/二 条件未授权
                }
            }

            __MemberAccountDetail__.Result result = null;
            Console.WriteLine("授权账号");
            foreach (var item in authorZombie)
            {
                result = back2.MemberAccountDetail(account: item.phone, beginDate: today.ToString("yyyy-MM-dd"), endDate: before30.ToString("yyyy-MM-dd"));
                if (result == null)
                {
                    Console.WriteLine("{0} - {1} 查询失败！", item.name, item.phone);
                }
                else
                {
                    Console.WriteLine("{0} - {1} 明细数量: {2}", item.name, item.phone, result.count);
                }
            }
            Console.WriteLine("未授权账号");
            foreach (var item in unauthorZombie)
            {
                result = back2.MemberAccountDetail(account: item.phone, beginDate: today.ToString("yyyy-MM-dd"), endDate: before30.ToString("yyyy-MM-dd"));
                if (result == null)
                {
                    Console.WriteLine("{0} - {1} 查询失败！", item.name, item.phone);
                }
                else
                {
                    Console.WriteLine("{0} - {1} 明细数量: {2}", item.name, item.phone, result.count);
                }
            }
        }

        private static List<__Member__.Result.cell> authorized = new List<__Member__.Result.cell>(3000);
        private static List<__Member__.Result.cell> unauthorized = new List<__Member__.Result.cell>(2000);
        private static void InitMember()
        {
            __Member__.Result result = back2.Member(1, 10);
            if (result != null)
            {
                int pages = result.count / 900 + 1;
                for (int i = 1; i <= pages; i++)
                {
                    result = back2.Member(i, 900);
                    if (result != null)
                    {
                        foreach (var item in result.data)
                        {
                            if (item.authStatus == 2)// 已认证
                            {
                                authorized.Add(item);
                            }
                            if (item.authStatus == 0)// 未认证
                            {
                                unauthorized.Add(item);
                            }
                        }
                    }
                    Console.WriteLine("第{0}页", i);
                }
            }
            Console.WriteLine("已认证，共{0}条", authorized.Count);
            Console.WriteLine("未认证，共{0}条", unauthorized.Count);
        }
    }
}
