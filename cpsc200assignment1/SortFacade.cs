﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class SortFacade
    {
        private InsertionSort IS;
        public InsertionSort iS
        {
            get { return IS; }
        }
        private SelectionSort SS;
        public SelectionSort sS
        {
            get { return SS; }
        }
        private ShellSort SHS;
        public ShellSort shS
        {
            get { return SHS; }
        }
        public SortFacade()
        {
            IS = new InsertionSort();
            SS = new SelectionSort();
            SHS = new ShellSort();
        }

        public void sort(ExperimentParams e)
        {
            
            switch (e.sortType)
            {
                case Sorts.insertionSort:
                {
                    Sort jSort = (Sort)iS;
                    jSort.sort(e.list);
                    break;
                }
                case Sorts.selectionSort:
                {
                    Sort kSort = (Sort)sS;
                    kSort.sort(e.list);
                    break;
                }
                case Sorts.shellSort:
                {
                    Sort lSort = (Sort)shS;
                    lSort.sort(e.list);
                    break;
                }
                default :
                {
                    break;
                }
            }
        }
    }
}