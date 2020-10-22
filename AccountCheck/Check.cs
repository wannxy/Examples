using NDevHelper_V1.Log;
using NDevHelper_V1.Net.Back2Api;
using NDevHelper_V1.Net.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AccountCheck
{
    class Check
    {
        private static Back2Client back2 = new Back2Client("2CEF7A7D7FE8B441F6038FF6307937E0", "Back2");

        /// <summary>
        /// 羊毛党
        /// 1: 无充值订单
        /// 2: 资金明细内只有手机运动收益且总记录条数不超过500
        /// </summary>
        public static void wool()
        {
            if (authorized.Count <= 0 || unauthorized.Count <= 0)
            {
                XLog.E("", "数据未就绪");
                return;
            }
            List<__Member__.Result.cell> authorWool = new List<__Member__.Result.cell>(3000);
            List<__Member__.Result.cell> unauthorWool = new List<__Member__.Result.cell>(2000);
            ReadOnlyCollection<__Member__.Result.cell> onlyAuthor = authorized.AsReadOnly();
            ReadOnlyCollection<__Member__.Result.cell> onlyUnauthor = unauthorized.AsReadOnly();

            __CoinRecharges__.Result rechargesResult;
            int i = 0;
            foreach (var item in onlyAuthor)
            {
                if (TauthorZombie.Contains(item.phone))
                {
                    continue;
                }
                rechargesResult = back2.CoinRecharges(phone: item.phone);
                if (rechargesResult == null)
                {
                    MainForm.WoolCallback(string.Format("{0} 充值订单查询失败！", item));
                }
                else
                {
                    if (rechargesResult.count <= 0)// 满足第一条件，无充值订单
                    {
                        authorWool.Add(item);
                        MainForm.WoolCallback(string.Format("授权充值订单[{0}]: {1}", i++, rechargesResult.count));
                    }
                }
            }
            foreach (var item in onlyUnauthor)
            {
                if (TunAuthorZombie.Contains(item.phone))
                {
                    continue;
                }
                rechargesResult = back2.CoinRecharges(phone: item.phone);
                if (rechargesResult == null)
                {
                    MainForm.WoolCallback(string.Format("{0} 充值订单查询失败！", item));
                }
                else
                {
                    if (rechargesResult.count <= 0)// 满足第一条件，无充值订单
                    {
                        authorWool.Add(item);
                        MainForm.WoolCallback(string.Format("未授权充值订单[{0}]: {1}", i++, rechargesResult.count));
                    }
                }
            }
            __MemberAccountDetail__.Result result;
            MainForm.WoolCallback("授权账号");
            bool found = false;
            foreach (var item in authorWool)
            {
                if (TauthorZombie.Contains(item.phone))
                {
                    continue;
                }
                result = back2.MemberAccountDetail(account: item.phone);
                if (result == null)
                {
                    MainForm.WoolCallback(string.Format("{0} 资金明细查询失败", item));
                }
                if (result.count <= 500)
                {
                    foreach (var cell in result.data)
                    {
                        if ("3".Equals(cell.accountType))// 资金账户
                        {
                            if ("手机运动收益".Equals(cell.mark))
                            {
                                continue;
                            }
                            if ("运动推荐手机挖矿收益".Equals(cell.mark))
                            {
                                continue;
                            }
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        MainForm.WoolCallback(string.Format("{0}", item));
                    }
                    found = false;
                }
            }
            MainForm.WoolCallback("未授权账号");
            foreach (var item in unauthorWool)
            {
                if (TunAuthorZombie.Contains(item.phone))
                {
                    continue;
                }
                result = back2.MemberAccountDetail(account: item.phone);
                if (result == null)
                {
                    MainForm.WoolCallback(string.Format("{0} 资金明细查询失败", item));
                }
                if (result.count <= 500)
                {
                    foreach (var cell in result.data)
                    {
                        if ("3".Equals(cell.accountType))// 资金账户
                        {
                            if ("手机运动收益".Equals(cell.mark))
                            {
                                continue;
                            }
                            if ("运动推荐手机挖矿收益".Equals(cell.mark))
                            {
                                continue;
                            }
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        MainForm.WoolCallback(string.Format("{0} ", item));
                    }
                    found = false;
                }
            }

        }

        private static List<string> TauthorZombie = new List<string>(3000);
        private static List<string> TunAuthorZombie = new List<string>(2000);
        /// <summary>
        /// 检查僵尸号<br/>
        /// 1: 注册时间为15天的账号<br/>
        /// 2: 3账号资产全部为0<br/>
        /// 3: 资金明细一个月内未任何记录<br/>
        /// </summary>
        public static void zombie()
        {
            if (authorized.Count <= 0 || unauthorized.Count <= 0)
            {
                XLog.E("", "数据未就绪");
                return;
            }
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime before15 = today.AddDays(-5);
            DateTime before30 = today.AddDays(-5);
            List<__Member__.Result.cell> authorZombie = new List<__Member__.Result.cell>(3000);
            List<__Member__.Result.cell> unauthorZombie = new List<__Member__.Result.cell>(2000);
            ReadOnlyCollection<__Member__.Result.cell> onlyAuthor = authorized.AsReadOnly();
            ReadOnlyCollection<__Member__.Result.cell> onlyUnauthor = unauthorized.AsReadOnly();

            foreach (var item in onlyAuthor)
            {
                if (item.registerTime < before15 &&
                    item.aci == 0 && item.mineAci == 0 && item.contractAci == 0 &&
                    item.asi == 0 && item.mineAsi == 0 && item.contractAsi == 0 &&
                    item.usdt == 0 && item.mineUsdt == 0 && item.contractUsdt == 0)
                {
                    authorZombie.Add(item);// 符合第一/二 条件已授权
                }
            }
            foreach (var item in onlyUnauthor)
            {
                if (item.registerTime < before15 &&
                    item.aci == 0 && item.mineAci == 0 && item.contractAci == 0 &&
                    item.asi == 0 && item.mineAsi == 0 && item.contractAsi == 0 &&
                    item.usdt == 0 && item.mineUsdt == 0 && item.contractUsdt == 0)
                {
                    unauthorZombie.Add(item);// 符合第一/二 条件未授权
                }
            }

            __MemberAccountDetail__.Result result;
            MainForm.ZombieCallback("授权账号");
            foreach (var item in authorZombie)
            {
                result = back2.MemberAccountDetail(account: item.phone, beginDate: before30.ToString("yyyy-MM-dd"), endDate: today.ToString("yyyy-MM-dd"));
                if (result == null)
                {
                    MainForm.ZombieCallback(string.Format("{0} 查询失败！", item));
                }
                else
                {
                    MainForm.ZombieCallback(string.Format("{0} 明细数量: {1}", item, result.count));
                    TauthorZombie.Add(item.phone);
                }
            }
            MainForm.ZombieCallback("未授权账号");
            foreach (var item in unauthorZombie)
            {
                result = back2.MemberAccountDetail(account: item.phone, beginDate: before30.ToString("yyyy-MM-dd"), endDate: today.ToString("yyyy-MM-dd"));
                if (result == null)
                {
                    MainForm.ZombieCallback(string.Format("{0} 查询失败！", item));
                }
                else
                {
                    MainForm.ZombieCallback(string.Format("{0} 明细数量: {1}", item, result.count));
                    TunAuthorZombie.Add(item.phone);
                }
            }
        }

        private static List<__Member__.Result.cell> authorized = new List<__Member__.Result.cell>(3000);
        private static List<__Member__.Result.cell> unauthorized = new List<__Member__.Result.cell>(2000);
        public static void InitMember()
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
                    MainForm.ZombieCallback(string.Format("第{0}页", i));
                }
            }
            MainForm.ZombieCallback(string.Format("已认证，共{0}条", authorized.Count));
            MainForm.ZombieCallback(string.Format("未认证，共{0}条", unauthorized.Count));
        }
    }
}
