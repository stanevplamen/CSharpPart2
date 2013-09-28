using System;

class BinarySearch
{
    static void Main()
    {
        int[] intArray = { 2, 4, 5, 6, 8, 10, 12, 15 };
        Array.Sort(intArray);
        int firstMember = 0;
        int lastMember = intArray.Length - 1;
        int midMember = (firstMember + lastMember) / 2;

        int target = 11;    // The index should be found for this element
        int index = -1;     // here will be copy the requested index of target

        while (lastMember >= firstMember)
        {
            midMember = (firstMember + lastMember) / 2;

            if (intArray[midMember] < target)
            {
                // change min index to search upper subarray part
                firstMember = midMember + 1;
            }
            else if (intArray[midMember] > target)
            {
                // change max index to search lower subarray part
                lastMember = midMember - 1;
            }
            else
            {
                index = midMember;
                break;
            }
        }
        if (index >= 0)
        {
            Console.WriteLine("The requestred number {0} is at index {1}", target, index);
        }
        else if (index < 0)
        {
            Console.WriteLine("The index of the requestred number {0} was not found", target);
        }
    }
}
