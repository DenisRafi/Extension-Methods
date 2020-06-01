/*
C# Extension Methods

Example shows how to call the standard query operator.
OrderBy method on an array of integers.
The expression in parentheses is a lambda expression.
Many standard query operators take lambda expressions as parameters, 
but this isn't a requirement for extension methods.
 
By Denis Rafi
 */
using System.Linq;
namespace CA
{
    class Program
    {
        static void Main()
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }
        }
    }
}
//Output: 1 2 3 4 5 6 7 8 9 10