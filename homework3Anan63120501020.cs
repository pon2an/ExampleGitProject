using System;

namespace homework3
{

    class Node
    {
        public Node Next;

        public char Instruction;
        public char Data;

        public Node(char instructionValue, char dataValue)
        {   Instruction = instructionValue; Data = dataValue;   }

        public Node Copy()
        {   return new Node(Instruction, Data);   }

        public override string ToString()
        {   return string.Format("({0},{1})", Instruction, Data);   }
    }

        class Queue
        {
            private Node root;

            public void Insert(Node node, int index)
            {
                if (index == 0)
                {   node.Next = root; root = node;   }
                else
                {   index--; Node prevPtr = root; 
                while (index > 0)
                    {    index--; prevPtr = prevPtr.Next;   }
                    node.Next = prevPtr.Next; prevPtr.Next = node;
                }
            }

            public void Push(Node node)
            {
                if (root == null)
                {   root = node;   }
                else
                {
                    Node ptr = root; 
                while (ptr.Next != null)
                    {   ptr = ptr.Next;   }
                    ptr.Next = node;
                }
            }

            public Node Pop()
            {
                Node node = root;
                if (root != null)
                {   root = root.Next; node.Next = null;   }
                return node;
            }

            public int GetLength()
            {
                Node ptr = root; int length = 0;
                while (ptr != null)
                {   length++; ptr = ptr.Next;   }
                return length;
            }

            public void Join(Queue otherQueue)
            {   Push(otherQueue.root);   }

            public Queue Copy()
            {
                Queue newQueue = new Queue(); Node ptr = root;
                while (ptr != null)
                {   newQueue.Push(ptr.Copy()); ptr = ptr.Next;   }

                return newQueue;
            }

            public override string ToString()
            {
                string message = "["; Node ptr = root;
                while (ptr != null)
                {   message += ptr + ","; ptr = ptr.Next;   }
                message += "]";
                return message;
            }
        }


    class Program
    {
        static Queue AllocateInstructionAndDataToCpu(ref char[] cpuInstruction, ref char[,] cpuData, ref Queue queue)
        {
            Queue exceedQueue = new Queue();

            while (queue.GetLength() > 0)
            {
                Node node = queue.Pop();

                int cpuWithInstructionIndex = Array.IndexOf(cpuInstruction, node.Instruction);

                if (cpuWithInstructionIndex == -1)
                {
                    int cpuEmptyInstructionIndex = Array.IndexOf(cpuInstruction, '\0');

                    if (cpuEmptyInstructionIndex == -1)
                    {   queue.Insert(node, 0); break;   }
                    else
                    {
                        cpuInstruction[cpuEmptyInstructionIndex] = node.Instruction;
                        cpuData[cpuEmptyInstructionIndex, 0] = node.Data;
                    }
                }
                else
                {
                    bool canProcess = false;
                    for (int i = 0; i < cpuData.GetLength(1); i++)
                    {
                        if (cpuData[cpuWithInstructionIndex, i] == node.Data)
                        {   canProcess = true; break;   }
                        else if (cpuData[cpuWithInstructionIndex, i] == '\0')
                        {   cpuData[cpuWithInstructionIndex, i] = node.Data; canProcess = true; break;   }
                    }

                    if (!canProcess)
                    {   exceedQueue.Push(node);   }
                }

            }

            return exceedQueue;
        }

        static int ProcessInstructionAndData(ref char[] cpuInstruction, ref char[,] cpuData, ref Queue mainQueue, ref Queue temporaryQueue)
        {
            int cycle = 0;

            while (temporaryQueue.GetLength() + mainQueue.GetLength() > 0)
            {
                cycle++;

                if (temporaryQueue.GetLength() > 0)
                {
                    Queue exceedQueue = AllocateInstructionAndDataToCpu(ref cpuInstruction, ref cpuData, ref temporaryQueue);
                    temporaryQueue.Join(exceedQueue);
                }

                if (mainQueue.GetLength() > 0)
                {
                    Queue exceedQueue = AllocateInstructionAndDataToCpu(ref cpuInstruction, ref cpuData, ref mainQueue);
                    temporaryQueue.Join(exceedQueue);
                }

                cpuInstruction = new char[cpuInstruction.Length];
                cpuData = new char[cpuData.GetLength(0), cpuData.GetLength(1)];
            }

            return cycle;
        }

        static void Main(string[] args)
        {
            char[] cpuInstruction = new char[4]; char[,] cpuData = new char[4, 3];

            Queue mainQueue = new Queue(); Queue temporaryQueue = new Queue();

            char inputInstruction, inputData;
            while (true)
            {
                inputInstruction = char.Parse(Console.ReadLine());

                if (inputInstruction == '?')
                {   break;   }

                inputData = char.Parse(Console.ReadLine());
                Node inputNode = new Node(inputInstruction, inputData);
                mainQueue.Push(inputNode);
            }

            int cycle = ProcessInstructionAndData(ref cpuInstruction, ref cpuData, ref mainQueue, ref temporaryQueue);
            Console.WriteLine("CPU cycles needed: {0}", cycle);
        }
    }
}