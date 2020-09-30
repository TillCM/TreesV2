using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesV2.NodeClass
{
    class CNode
    {
        CNode  left;
        CNode right;
        int  Data;

        public CNode(int Data)
        {
            this.Data = Data;
        }

        public void Insert(int valuetoInsert)
        {
            if (valuetoInsert <= Data)
            {
                if ( left == null)
                {
                    left = new CNode(valuetoInsert);
                }
                else
                {
                    left.Insert(valuetoInsert);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new CNode(valuetoInsert);
                }

                else
                {
                    right.Insert(valuetoInsert);
                }
            }
        }

        public bool Contains (int valueToFind)
        {
            if (valueToFind == Data)
            {
                return true;
            }

            else
            {
                if (valueToFind < Data)
                {
                    if (left == null)
                    {
                        return false;
                    }

                    else 
                    {
                        return left.Contains(valueToFind);
                    } 
                }

                else
                {
                    if (right == null)
                    {
                        return false;
                    }

                    else 
                    {
                        return right.Contains(valueToFind);
                    }
                }
                
               
            }
        }
    }
}
