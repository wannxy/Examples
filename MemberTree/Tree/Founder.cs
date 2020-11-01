using NDevHelper_V1.Log;
using NDevHelper_V1.Net.Back2Api;
using NDevHelper_V1.Tool;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MemberTree.Tree
{
    public class Founder
    {
        private Dictionary<string, __Member__.Result.cell> Cache;
        private Dictionary<string, Node> DicTree;
        private Dictionary<string, Node> Discard;

        public Founder(Dictionary<string, __Member__.Result.cell> cache)
        {
            Cache = cache;
            DicTree = new Dictionary<string, Node>(6000);
            Discard = new Dictionary<string, Node>(5000);
        }

        public void Found()
        {
            Node root = null;
            int i = 0;
            long start;

            foreach (var item in Cache.Values)
            {
                start = Helper.GetCurrentMillisecond();
                root = new Node(item.id, item, 1);
                FindUsers(root);
                DicTree.Add(item.id, root);
                root.TotalChildrenSize();
                XLog.I("Founder", "已构建社区树[ {0} ]: {1}/{2} ,T: {3} ,S: {4}", item.phone, ++i, Cache.Count, Helper.GetCurrentMillisecond() - start, root.TotalSize);
                if ("17167986016".Equals(item.phone))
                {
                    destId = item.id;
                }
            }
            //Merge();
        }

        string destId = "";
        public void FindPhones(string[] phones)
        {
            DicTree[destId].FindList(phones);
        }


        public void Merge()
        {
            bool found;
            string[] keys = DicTree.Keys.ToArray();
            Node[] nodes = DicTree.Values.ToArray();

            foreach (var key in keys)
            {
                found = false;
                foreach (Node node in nodes)
                {
                    if (node.Data.phone.Equals(DicTree[key].Data.phone))
                    {
                        continue;
                    }
                    if (node.FindPhoneInNode(DicTree[key].Data.phone) != null)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    Node node = DicTree[key];
                    Discard.Add(node.Id, node);
                    DicTree.Remove(key);
                }
            }
            Debug.WriteLine("有效: {0}, 无效: {1}", DicTree.Count, Discard.Count);
        }

        private void FindUsers(Node node)
        {
            if (node == null)
            {
                return;
            }
            Node[] TEMP = FindUsersForInviteCode(node.Data.inviteCode.Trim().ToLower(), node.Level + 1);
            if (TEMP == null)
            {
                return;
            }
            foreach (var item in TEMP)
            {
                node.AddChild(item.Id, item);
            }
            foreach (Node item in TEMP)
            {
                FindUsers(item);
            }
        }

        private Node[] FindUsersForInviteCode(string inviteCode, int level)
        {
            List<Node> nodes = new List<Node>(5);
            string inviteYards = "";
            foreach (var id in Cache.Keys)
            {
                inviteYards = Cache[id].inviteYards;
                if (inviteYards == null)
                {
                    inviteYards = "";
                }
                if (inviteCode.Equals(inviteYards.Trim().ToLower()))
                {
                    nodes.Add(new Node(id, Cache[id], level));
                }
            }
            if (nodes.Count == 0)
            {
                return null;
            }
            return nodes.ToArray();
        }
    }
}
