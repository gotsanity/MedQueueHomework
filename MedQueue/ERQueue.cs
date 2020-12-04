using System;
using System.Collections.Generic;
using System.Text;

namespace MedQueue
{
    public class ERQueue
    {
        private const int MAXSIZE = 5;
        private Patient[] queue = new Patient[MAXSIZE];
        private int rear = -1;
        private int front = 0;
        private int itemCount = 0;

        public int Enqueue(Patient patient)
        {
            if (!IsFull())
            {
                if(rear == MAXSIZE - 1)
                {
                    rear = -1;
                }

                queue[++rear] = patient;
                itemCount++;
                return itemCount;
            }
            else
            {
                return -1;
            }
        }

        public Patient Dequeue()
        {
            Patient data = queue[front++];

            if (front == MAXSIZE)
            {
                front = 0;
            }
            itemCount--;
            return data;
        }

        public override string ToString()
        {
            string result = "";

            for (int i = front; i < (front + Size()); i++)
            {
                if (i > MAXSIZE - 1)
                {
                    result += queue[i - MAXSIZE].ToString() + "\n";
                }
                else
                {
                    result += queue[i].ToString() + "\n";
                }
                
            }

            return result;
        }

        public bool IsFull()
        {
            return itemCount == MAXSIZE;
        }

        public bool IsEmpty()
        {
            return itemCount == 0;
        }

        public int Size()
        {
            return itemCount;
        }
    }
}
