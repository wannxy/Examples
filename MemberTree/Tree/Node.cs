using NDevHelper_V1.Log;
using NDevHelper_V1.Net.Back2Api;
using System.Collections.Generic;

namespace MemberTree.Tree
{
    public class Node
    {
        public Node Parent { set; get; }
        public Dictionary<string, Node> Children { set; get; }
        public string Id { set; get; } = "";
        public __Member__.Result.cell Data { set; get; }
        public int ChildrenSize { set; get; } = 0;
        public int TotalSize { set; get; } = 0;
        public int Level { set; get; } = 0;

        public Node(string id, __Member__.Result.cell data, int level)
        {
            Children = new Dictionary<string, Node>(5);
            Id = id;
            Data = data;
            Level = level;
        }

        public void UpdateParent(Node node)
        {
            Parent = node;
        }

        public void AddChild(string id, Node node)
        {
            if (Children.ContainsKey(id))
            {
                Children.Remove(id);
            }
            Children.Add(id, node);
            ChildrenSize++;
        }

        public int TotalChildrenSize()
        {
            int size = 0;
            foreach (var item in Children.Values)
            {
                size += item.TotalChildrenSize();
            }
            TotalSize = size + ChildrenSize;
            return TotalSize;
        }

        public Node FindPhoneInNode(string phone)
        {
            if (phone.Equals(Data.phone))
            {
                return this;
            }
            foreach (var item in Children.Values)
            {
                Node node = item.FindPhoneInNode(phone);
                if (node != null)
                {
                    return node;
                }
            }
            return null;
        }

        public override bool Equals(object obj)
        {
            return obj is Node node &&
                   Id == node.Id;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Data.phone.Trim(), Level, TotalSize);
        }
    }
}
