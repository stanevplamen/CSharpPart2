using System;

class Strings
{
    static string mostImportantStringMethods = @"/* 
    The strings in C# are Arrays of chars with fixed length. Each string could be only read after the declaration.
    All the operations of strings result in different variable type string.
    The concatenation (sum) of any other type with type string is always type string.
    The concatenation of string many times (with loops) is not a suitable process, because its too slow.
    For that kind of operations, the StringBuilder class must be used, because via this class these kinds of 
    operations are performed immediately with no need of writing and reading the file every time.
    This class is very suitable and fast for many times repeating operations.
    The most important methods in the string class are:
 
     * Compare(String, String) - Compares two specified String objects and returns an integer that indicates their relative position 
    in the sort order.
     * Concat - Creates the string representation of a specified object.
     * Copy - Creates a new instance of String with the same value as a specified String.
     * IndexOf(Char) - Reports the zero-based index of the first occurrence of the specified Unicode character in this string.
     * IndexOf(String) - Reports the zero-based index of the first occurrence of the specified string in this instance.
     * PadLeft/PadRight - Returns a new string that aligns the characters in this instance by padding them with spaces,
    for a specified total length.
     * Remove - Returns a new string in which all the characters in the current instance, 
    beginning at a specified position and continuing through the last position, have been deleted.
     * Replace(Char, Char) - Returns a new string in which all occurrences of a specified Unicode character in this instance 
    are replaced with another specified Unicode character.
     * Replace(String, String) - Returns a new string in which all occurrences of a specified string in the current instance 
    are replaced with another specified string.
     * Split - Returns a string array that contains the substrings in this instance that are delimited by elements of a specified 
    Unicode character array.
     * ToLower/ToUpper - Returns a copy of this string converted to lowercase / uppercase.
     * ToString - Returns this instance of String; no actual conversion is performed. (Overrides Object.ToString().)
     * Trim - Removes all leading and trailing white-space characters from the current String object.
 
    All the methods could be found at: http://msdn.microsoft.com/en-us/library/system.string_methods%28v=vs.71%29.aspx 
    */";

    static void Main()
    {
        Console.WriteLine(mostImportantStringMethods);
    }
}

