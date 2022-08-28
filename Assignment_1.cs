using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSolution
{
    class Assignment_1
    {
        static void FindVariableRange()
        {
            Console.WriteLine($"The Range of Byte is {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"The Range of Int is {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"The Range of FLoat is {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"The Range of Long is {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"The Range of Double is {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"The Range of Short is {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"The Range of Unsigned Byte is {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"The Range of Unsigned Int is {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"The Range of Unsigned Long is {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine($"The Range of Unsigned Short is {ushort.MinValue} to {ushort.MaxValue}");

        }
        static void Main(string[] args)
        {
            FindVariableRange();
        }
    }
}
