using System;
using System.Collections;


namespace Algorytmy
{
    class TowerOfHanoi
    {
        public void recursion(int iloscDyskow, String skad, String dokad, String pom)
        {
            if (iloscDyskow == 1)
            {

            }
            else
            {
                recursion(iloscDyskow - 1, skad, pom, dokad);
                recursion(1, skad, dokad, pom);
                recursion(iloscDyskow - 1, pom, dokad, skad);
            }
        }

        public class Stack
        {
            public int capacity;
            public int top;
            public int[] array;
        }
 
        Stack createStack(int capacity)
        {
            Stack stack = new Stack();
            stack.capacity = capacity;
            stack.top = -1;
            stack.array = new int[capacity];
            return stack;
        }

        Boolean isFull(Stack stack)
        {
            return (stack.top == stack.capacity - 1);
        }

        Boolean isEmpty(Stack stack)
        {
            return (stack.top == -1);
        }

        void push(Stack stack, int item)
        {
            if (isFull(stack))
                return;
            stack.array[++stack.top] = item;
        }

        int pop(Stack stack)
        {
            if (isEmpty(stack))
                return int.MinValue;
            return stack.array[stack.top--];
        }

        void moveDisksBetweenTwoPoles(Stack src, Stack dest, char s, char d)
        {
            int pole1TopDisk = pop(src);
            int pole2TopDisk = pop(dest);
 
            if (pole1TopDisk == int.MinValue)
            {
                push(src, pole2TopDisk);
                moveDisk(d, s, pole2TopDisk);
            }
            else if (pole2TopDisk == int.MinValue)
            {
                push(dest, pole1TopDisk);
                moveDisk(s, d, pole1TopDisk);
            } 
            else if (pole1TopDisk > pole2TopDisk)
            {
                push(src, pole1TopDisk);
                push(src, pole2TopDisk);
                moveDisk(d, s, pole2TopDisk);
            } 
            else
            {
                push(dest, pole2TopDisk);
                push(dest, pole1TopDisk);
                moveDisk(s, d, pole1TopDisk);
            }
        }

        void moveDisk(char fromPeg, char toPeg, int disk)
        {}

        void tohIterative(int num_of_disks, Stack
                    src, Stack aux, Stack dest)
        {
            int i, total_num_of_moves;
            char s = 'S', d = 'D', a = 'A';

            if (num_of_disks % 2 == 0)
            {
                char temp = d;
                d = a;
                a = temp;
            }
            total_num_of_moves = (int)(Math.Pow(2, num_of_disks) - 1);
 
            for (i = num_of_disks; i >= 1; i--)
                push(src, i);

            for (i = 1; i <= total_num_of_moves; i++)
            {
                if (i % 3 == 1)
                    moveDisksBetweenTwoPoles(src, dest, s, d);

                else if (i % 3 == 2)
                    moveDisksBetweenTwoPoles(src, aux, s, a);

                else if (i % 3 == 0)
                    moveDisksBetweenTwoPoles(aux, dest, a, d);
            }
        }

        public void iteration(int iloscDyskow)
        {
            TowerOfHanoi hanoi = new TowerOfHanoi();
            Stack skad, dokad, pom;

            skad = hanoi.createStack(iloscDyskow);
            dokad = hanoi.createStack(iloscDyskow);
            pom = hanoi.createStack(iloscDyskow);
            hanoi.tohIterative(iloscDyskow, skad, pom, dokad);
        }
    }
}