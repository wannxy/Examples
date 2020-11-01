using NDevHelper_V1.Log;
using NDevHelper_V1.Net;
using NDevHelper_V1.Net.Back2Api;
using NDevHelper_V1.Net.Client;
using NDevHelper_V1.Tool;
using System.Collections.Generic;

namespace MemberTree
{
    public class MemberCache
    {
        public static string TAG = "Cache";
        private static MemberCache memberCache;
        private Back2Client back2;
        private static Dictionary<string, __Member__.Result.cell> Cache;

        private MemberCache()
        {
            back2 = ClientManager.GetManager().GetClient<Back2Client>("Back2");
            Cache = new Dictionary<string, __Member__.Result.cell>(5000);
        }

        public static Dictionary<string, __Member__.Result.cell> Init()
        {
            if (memberCache == null)
            {
                memberCache = new MemberCache();
            }
            memberCache.InitCache();
            return Cache;
        }

        private bool InitCache()
        {
            __Member__.Result result = back2.Member(1, 10);
            if (result == null)
            {
                XLog.I(TAG, "用户数据初始化失败!");
                return false;
            }
            int count = result.count;
            int pages = count / 1000 + 1;
            for (int i = 1; i <= pages; i++)
            {
                XLog.I(TAG, "正在初始化用户数据! ( {0}/{1} )", i, pages);
                result = back2.Member(i, 1000);
                if (result == null || result.data == null)
                {
                    XLog.I(TAG, "用户数据初始化失败!");
                    return false;
                }
                foreach (__Member__.Result.cell item in result.data)
                {
                    if (item.phone == null || "".Equals(item.phone))
                    {
                        item.phone = string.Format("未知{0}", Helper.GetCurrentMillisecond()); // 把手机号为空的账户都填充了
                    }
                    if (Cache.ContainsKey(item.id))
                    {
                        Cache.Remove(item.id);
                    }
                    Cache.Add(item.id, item);
                }
            }
            if (Cache.Count == count)
            {
                XLog.I(TAG, "用户数据初始化结束! 共计: {0}", count);
                return true;
            }
            else
            {
                XLog.I(TAG, "用户数据初始化失败! 用户数据数量与预期不符! 预期: {0}, 实际: {1}", count, Cache.Count);
                return false;
            }
        }
    }
}
