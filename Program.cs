﻿using System;
using System.Linq;
using CrackingTheCodingInterview.Problems;
using CrackingTheCodingInterview.Utilities;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main()
        {
            //Chapter1();
            //Chapter2();
            Chapter4();
        }

        static void Chapter1()
        {
            Chap1_ArraysAndStrings.Prob1_IsUnique("zsdfg");
            Chap1_ArraysAndStrings.Prob2_CheckPermutation("zsdfg", "zszfg");
            Console.WriteLine(Chap1_ArraysAndStrings.Prob3_Urlify("Mr John Smith"));
            Chap1_ArraysAndStrings.Prob4_PalindromePermutation("Tact Coa");
        }

        static void Chapter2()
        {
            //linkedList.PrintLinkedList();
            //Chap2_LinkedLists.Prob1_RemoveDups(Chap2_LinkedLists.CreateTestLinkedList1());
            //linkedList.PrintLinkedList();

            //Chap2_LinkedLists.KthToLast(Chap2_LinkedLists.CreateTestLinkedList1(), 4);
            //Chap2_LinkedLists.Prob4_Partition(Chap2_LinkedLists.CreateTestLinkedList1());
            Chap2_LinkedLists.Prob5_SumListsReverseOrder(Chap2_LinkedLists.CreateTestLinkedList1(), Chap2_LinkedLists.CreateTestLinkedList2());
            Chap2_LinkedLists.Prob5_SumLists(Chap2_LinkedLists.CreateTestLinkedList1(), Chap2_LinkedLists.CreateTestLinkedList2());

            Console.ReadLine();
        }

        static void Chapter4()
        {
            var graph = new Graph(true);

            Chap4_TreesAndGraphs.Prob1_RouteBetweenNodes(graph, graph.Nodes.First(), graph.Nodes.Last());
        }
    }
}