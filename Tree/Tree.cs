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
            bool added = false;
            temp = root;
            Node adNo = new Node();
            adNo.number = x;
            adNo.left = null;
            adNo.right = null;

            if (root == null)
            {
                root = adNo;
            }
            else
            { 
                if (adNo.number > temp.number)
                {
                    if (temp.right == null)
                    {
                        temp.right = adNo;
                        added = true;
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
                        temp.left = adNo;
                        added = true;
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
