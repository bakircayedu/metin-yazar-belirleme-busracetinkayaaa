using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariÖdev
{
    // Kaynak: Dr. Okan Öztürkmenoğlu Sunumu
   public class Heap
    {
        private int currentSize;
        private int maxSize;
        private HeapNode[] heapArray;

        public Heap(int _maxSize)
        {
            currentSize = 0;
            maxSize = _maxSize;
            heapArray = new HeapNode[maxSize];
        }

        public bool Insert(Node value)
        {
            if (currentSize == maxSize)
            {
                return false;
            }

            HeapNode newHeap = new HeapNode(value);
            heapArray[currentSize] = newHeap;
            MoveToUp(currentSize++);
            return true;
        }

        private void MoveToUp(int index)
        {
            int parent = GetParent(index);
            HeapNode bottom = heapArray[index];

            while (index > 0 && bottom.data.frequency > heapArray[parent].data.frequency)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = GetParent(parent);
            }

            heapArray[index] = bottom;
        }

        public void RemoveMax()
        {
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
        }

        private void MoveToDown(int index)
        {
            int largerChild;
            HeapNode top = heapArray[index];

            while (index < currentSize / 2)
            {
                int leftChild = GetLeftChild(index);
                int rightChild = GetRightChild(index);

                if (rightChild < currentSize && heapArray[leftChild].data.frequency < heapArray[rightChild].data.frequency)
                {
                    largerChild = rightChild;
                }
                else
                {
                    largerChild = leftChild;
                }

                if (top.data.frequency >= heapArray[largerChild].data.frequency)
                {
                    break;
                }

                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }

            heapArray[index] = top;
        }

        private int GetParent(int index) => (index - 1) / 2;
        private int GetLeftChild(int index) => 2 * index + 1;
        private int GetRightChild(int index) => 2 * index + 2;

    }
}
