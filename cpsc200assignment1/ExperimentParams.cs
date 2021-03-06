﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class ExperimentParams
    {
        private int ArraySize;
        public int arraySize
        {
            get { return ArraySize; }
        }
        private ArrayType aT;
        public ArrayType arrayType
        {
            get { return aT; }
        }
        private bool ArrayCheck = true;
        public bool arrayCheck
        {
            get { return ArrayCheck; }
            set { ArrayCheck = value; }
        }
        private long runtime;
        public long runTime
        {
            get { return runtime; }
            set {runtime = value; }
        }
        private int Memory;
        public int memory
        {
            get { return Memory; }
            set { Memory = value; }
        }
        private GenArray GenArray;
        private SortParams S;
        public SortParams s
        {
            get { return S; }
        }
        private int[] List;
        public int[] list
        {
            get { return List; }
            set { List = value; }
        }
        public ExperimentParams()
        {
            ArraySize = 0;
            GenArray = new GenArray();
            S = new SortParams();
        }

        public void setParams(int arraySize)
        {
            ArraySize = arraySize;
            List = GenArray.genArray(ArraySize,list);
        }

        public void setParams(int arraySize, GapType gapType)
        {
            s.gapType = gapType;
            ArraySize = arraySize;
            s.gapSequence = GapSeq.GapSequence(gapType, ArraySize);
            List = GenArray.genArray(ArraySize,list);
        }

        public void setParams(int arraySize, SortDirection arrayDirection, Sorts sorts, ArrayType arrayType )
        {
            ArraySize = arraySize;
            S.sortDirection = arrayDirection;
            S.sortType = sorts;
            aT = arrayType;
            List = GenArray.genArray(arrayType, ArraySize,list);
        }

        public void setParams(int arraySize, SortDirection arrayDirection, Sorts sorts, ArrayType arrayType , GapType gapType)
        {
            ArraySize = arraySize;
            S.sortDirection = arrayDirection;
            S.sortType = sorts;
            aT = arrayType;
            s.gapSequence = GapSeq.GapSequence(gapType,arraySize);
            List = GenArray.genArray(ArraySize,list);
        }
    }
}
