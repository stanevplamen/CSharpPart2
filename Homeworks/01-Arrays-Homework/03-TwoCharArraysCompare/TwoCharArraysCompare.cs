using System;
using System.Collections.Generic;

class TwoCharArraysCompare
{
    static void Main()
    {
        Console.WriteLine("Please enter all the elements of the char array #1 (on one row without spaces):");
        string charsOne = Console.ReadLine();

        Console.WriteLine("Please enter all the elements of the char array #2 (on one row without spaces):");
        string charsTwo = Console.ReadLine();

        List<char> charListOne = new List<char>();
        List<char> charListTwo = new List<char>();


        foreach (char oneS in charsOne)
        {
            charListOne.Add(oneS);
        }
        foreach (char twoS in charsTwo)
        {
            charListTwo.Add(twoS);
        }


        if (charListOne.Count == charListTwo.Count)
        {
            for (int i = 0; i < charListOne.Count; i++)
            {
                if (charListOne[i] == charListTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 (char) element: {1} == Array #2 (char) element: {2}", i, charListOne[i], charListTwo[i]);
                }
                else if (charListOne[i] != charListTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 (char) element: {1} != Array #2 (char) element: {2}", i, charListOne[i], charListTwo[i]);
                }
            }
        }
        else if (charListOne.Count > charListTwo.Count)
        {
            for (int i = 0; i < charListTwo.Count; i++)
            {
                if (charListOne[i] == charListTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 (char) element: {1} == Array #2 (char) element: {2}", i, charListOne[i], charListTwo[i]);
                }
                else if (charListOne[i] != charListTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 (char) element: {1} != Array #2 (char) element: {2}", i, charListOne[i], charListTwo[i]);
                }
            }
            for (int i = charListTwo.Count; i < charListOne.Count; i++)
            {
                Console.WriteLine("Element {0} : Array #1 (char) element: {1} != Array #2 is empty (null)", i, charListOne[i]);
            }
        }

        else if (charListOne.Count < charListTwo.Count)
        {
            for (int i = 0; i < charListOne.Count; i++)
            {
                if (charListOne[i] == charListTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 (char) element: {1} == Array #2 (char) element: {2}", i, charListOne[i], charListTwo[i]);
                }
                else if (charListOne[i] != charListTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 (char) element: {1} != Array #2 (char) element: {2}", i, charListOne[i], charListTwo[i]);
                }
            }
            for (int i = charListOne.Count; i < charListTwo.Count; i++)
            {
                Console.WriteLine("Element {0} : Array #1 (char) element is empty (null) != Array #2 (char) element {1}", i, charListTwo[i]);
            }
        }
    }
}

