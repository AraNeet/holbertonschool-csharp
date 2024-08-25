using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        if (myLList.First == null)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }
        LinkedListNode<int> currentNode = myLList.First;
        while (currentNode != null)
        {
            if (n < currentNode.Value)
            {
                myLList.AddBefore(currentNode, newNode);
                return newNode;
            }
            currentNode = currentNode.Next;
        }

        myLList.AddLast(newNode);
        return newNode;
    }
}