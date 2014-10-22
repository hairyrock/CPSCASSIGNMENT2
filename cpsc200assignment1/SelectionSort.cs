﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cpsc200assignment1
{
    class SelectionSort : Sort
    {
        private Stopwatch sW;
        private int[] list;
        private long mem1;
        private long mem2;
        public SelectionSort()
        {
            
        }

        public void sort(ExperimentParams e)
        {
            switch (e.sortDirection)
            {
                case SortDirection.normal:
                {
                    sortNormal(e);
                    break;
                }
                case SortDirection.reverse:
                {
                    sortReverse(e);
                    break;
                }
            }
        }

        private void sortNormal(ExperimentParams e)
        {
            list = e.list;
            sW = Stopwatch.StartNew();
            mem1 = GC.GetTotalMemory(false);
            int listSize = list.Length;
            int nextPos = 0;
            while(nextPos < listSize)
            {
                int minElement = nextPos;
                for(int i = nextPos + 1; i < listSize; i++)
                {
                    if(list[i] <  list[minElement])
                    {
                        minElement = i;
                    }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                list[nextPos] = temp;
                nextPos++;
            }
            sW.Stop();
            mem2 = GC.GetTotalMemory(false);
            e.memory = (int)(mem2 - mem1);
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
            //e.list = list;
        }

        private void sortReverse(ExperimentParams e)
        {
            list = e.list;
            sW = Stopwatch.StartNew();
            mem1 = GC.GetTotalMemory(false);
            int listSize = list.Length;
            int nextPos = 0;
            while (nextPos < listSize)
            {
                int minElement = nextPos;
                for (int i = nextPos + 1; i < listSize; i++)
                {
                    if (list[i] > list[minElement])
                    {
                        minElement = i;
                    }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                list[nextPos] = temp;
                nextPos++;
            }
            sW.Stop();
            mem2 = GC.GetTotalMemory(false);
            e.memory = (int)(mem2 - mem1);
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
            //e.list = list;
        } 
    }
}
