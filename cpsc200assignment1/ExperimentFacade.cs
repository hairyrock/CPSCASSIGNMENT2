﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class ExperimentFacade
    {
        private Experiment e;
        private CustomExperiment cE;
        private UnitTests uT;
        public ExperimentFacade()
        {
            e = new Experiment();
            cE = new CustomExperiment();
            uT = new UnitTests();
        }

        public void experimentUI()
        {
            Console.WriteLine("1. experiments");
            Console.WriteLine("2. Unit tests");
            Console.WriteLine("3. custom experiment");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        experiment();
                        break;
                    }
                case 2:
                    {
                        unitTests();
                        break;
                    }
                case 3:
                    {
                        cE.customExperiment();
                        experimentUI();
                        break;
                    }
                default:
                    {
                        experimentUI();
                        break;
                    }
            }

        }

        private void unitTests()
        {
            Console.WriteLine("1. run all sort unit tests");
            Console.WriteLine("2. selection sort unit tests");
            Console.WriteLine("3. insertion sort unit tests");
            Console.WriteLine("4. shell sort unit tests");
            Console.WriteLine("5. run genArray tests");
            int i = int.Parse(Console.ReadLine());
            switch(i)
            {
                case 1:
                {
                    uT.RunAllSortTests();
                    experimentUI();
                    break;
                }
                case 2:
                {
                    uT.selectionTest();
                    experimentUI();
                    break;
                }
                case 3:
                {
                    uT.insertionTest();
                    experimentUI();
                    break;
                }
                case 4:
                {
                    uT.shellTest();
                    experimentUI();
                    break;
                }

                case 6:
                {
                    uT.arrayGenerator();
                    experimentUI();
                    break;
                }
                default:
                {
                    Console.WriteLine("invalid input please try again");
                    experimentUI();
                    break;
                }
            }
        }

        private void experiment()
        {
            Console.WriteLine("please enter Experiment file name and path");
            e.setFile(Console.ReadLine());
            Console.WriteLine("1.   experiment 1");
            Console.WriteLine("2.   experiment 2");
            Console.WriteLine("3.   experiment 3");
            Console.WriteLine("4.   experiment 4");
            Console.WriteLine("5.   experiment 5");
            Console.WriteLine("6.   experiment 6");
            Console.WriteLine("7.   experiment 7");
            Console.WriteLine("8.   experimnet 8");
            Console.WriteLine("9.   experiment 9");
            Console.WriteLine("10.  experiment 10");
            Console.WriteLine("11.  run all experiments");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                {
                    e.runExperiment1();
                    experimentUI();
                    break;
                }
                case 2:
                {
                    e.runExperiment2();
                    experimentUI();
                    break;
                }
                case 3:
                {
                     e.runExperiment3();
                     experimentUI();
                     break;
                }
                case 4:
                {
                    e.runExperiment4();
                    experimentUI();
                    break;
                }
                case 5:
                {
                    e.runExperiment5();
                    experimentUI();
                    break;
                }
                case 6:
                {
                    e.runExperiment6();
                    experimentUI();
                    break;
                }
                case 7:
                {
                     e.runExperiment7();
                     experimentUI();
                     break;
                }
                case 8:
                {
                    e.runExperiment8();
                    experimentUI();
                    break;
                }
                case 9:
                {
                    e.runExperiment9();
                    experimentUI();
                    break;
                }
                case 10:
                {
                    e.runExperiment10();
                    experimentUI();
                    break;
                }
                case 11:
                {
                    e.runAllExperiment();
                    experimentUI();
                    break;
                }
                default:
                {
                    Console.WriteLine("invalid input please try again");
                    experiment();
                    break;
                }
            }
        }
    }
}
