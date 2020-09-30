using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreesV2.NodeClass;

namespace TreesV2.Binary_Trees
{
    class BinaryTree
    {
        CNode root;

        public void insertNode(int data)
        {
            if (root!= null)
            {
                root.Insert(data);
            }
            else
            {
                root = new CNode(data);
            }
        }

        public bool ContainsNode(int data)
        {
            if (root != null)
            {
                root.Contains(data);
            }
            return false;

        }

    }
}
