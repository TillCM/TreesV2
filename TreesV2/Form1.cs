using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreesV2.Binary_Trees;

namespace TreesV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.insertNode(10);
            binaryTree.insertNode(8);
            binaryTree.insertNode(50);
            binaryTree.insertNode(7);
            binaryTree.insertNode(1);

            binaryTree.ContainsNode(7);



            Tree<int> tree = new Tree<int>();
            tree.Root = new TreeNode<int>() { Data = 100 };
            tree.Root.Children = new List<TreeNode<int>>
                {
                new TreeNode<int>() { Data = 50, Parent = tree.Root },
                new TreeNode<int>() { Data = 1, Parent = tree.Root },
                new TreeNode<int>() { Data = 150, Parent = tree.Root }
                };

            tree.Root.Children[2].Children = new List<TreeNode<int>>()
               {
                new TreeNode<int>() { Data = 30, Parent = tree.Root.Children[2] }
               };

            tree.Root.Children[2].Children[0].Children = new List<TreeNode<int>>()
               {
                new TreeNode<int>() { Data = 8, Parent = tree.Root.Children[2].Children[0] }
               };





        }
    }
}
