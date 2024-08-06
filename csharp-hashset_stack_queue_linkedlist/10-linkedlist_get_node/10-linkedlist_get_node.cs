using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> currentNode = myLList.First;
        for (int i = 0; i < myLList.Count; i++)
        {
            if (n == i)
            {
                return currentNode.Value;
            }
            currentNode = currentNode.Next;
        }
        return 0;
    }
}