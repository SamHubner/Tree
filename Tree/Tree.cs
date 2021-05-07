using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        private Node root;
        public Node temp;

        public void add(int x)
        {
            temp = root;
            Node added = new Node();
            added.number = x;
            added.left = null;
            added.right = null;

            if (root == null)
            {
                root = added;
            }
            else
            { 
                if (added.number > temp.number)
                {
                    if (temp.right == null)
                    {
                        temp.right = added;
                    }
                    else
                    {
                        temp = temp.right;
                    }
                }
                else
                {
                    if (temp.left == null)
                    {
                        temp.left = added;
                    }
                    else
                    {
                        temp = temp.left;
                    }
                }
            }
        }

    }

}
