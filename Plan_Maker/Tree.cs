using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_Maker
{
    public class Tree
    {
        string name = string.Empty;
        string fullName = string.Empty;
        Tree parent = null;
        Tree[] nodes = new Tree[100];
        int count = 0;

        public string FullName { get => fullName; set => fullName = value; }
        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        internal Tree[] Nodes { get => nodes; set => nodes = value; }

        public void Add_Node(Tree node)
        {
            this.nodes[Count] = node;
            Count++;
            node.parent = this;
        }
        public void Remove_Node(Tree node)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.nodes[i] == node)
                {
                    for (int j = i; j < Count - 1; j++)
                        this.nodes[j] = this.nodes[j + 1];
                    break;
                }
            }
        }
        public Tree FindFullName(string fullname)
        {
            Tree new_node = new Tree();
            if (fullname.Contains(this.fullName))
            {
                if (this.Nodes.Length == 0) new_node= this;
                else
                    for (int i = 0; i < this.Count; i++)
                        new_node = this.Nodes[i].FindFullName(fullname);
            } 
            return new_node;
        }
    }
}
