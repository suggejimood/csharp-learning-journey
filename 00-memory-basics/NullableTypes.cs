using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp._00_memory_basics
{
    internal class NullableTypes
    {
        public static void Run() 
        {
            Console.WriteLine("=== Nullable Values Types ===");
            int? numberOne = null;
            int? numberTwo = 27;

            Console.WriteLine($"numberOne.hasValue {numberOne.HasValue}"); //False
            Console.WriteLine($"numberTwo.hasValue {numberTwo.HasValue}"); //True
            Console.WriteLine($"numberTwo.Value {numberTwo.Value}"); //27

            Console.WriteLine("=== Null Coalescing (??) Operator ==");
            int result = numberOne ?? 40;
            Console.WriteLine($"result: {result}"); //40

            Console.WriteLine("\n=== Null Coalescing Assignment (??=) ===");
            int? numberX = null;
            numberX ??= 5;
            Console.WriteLine($"numberX: {numberX}"); //5

            Console.WriteLine("\n=== Null Conditional Operator (?.) ===");
            Person? person = null;
            Console.WriteLine($"person?.Name: {person?.Name}");  //

            person = new Person { Name = "Ahmet" };
            Console.WriteLine($"person?.Name: {person?.Name}");  //Ahmet
        }

        class Person
        {
            public string? Name { get; set; }
        }
    }
}
