/*

6kyu Unique in Order

Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

For example:

uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
uniqueInOrder([1,2,2,3,3])       == {1,2,3}

Algorithms
Fundamentals

*/

using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> uniqueList = new List<T>();

        T previousItem = default(T);

        foreach(T item in iterable)
        {
            if(!EqualityComparer<T>.Default.Equals(item, previousItem))
            {
                uniqueList.Add(item);
                previousItem = item;
            }
        }
        return uniqueList;
    }
}