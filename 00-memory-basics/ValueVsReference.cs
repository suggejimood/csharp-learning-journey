using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp._00_memory_basics
{
    internal class ValueVsReference
    {
        public static void Run()
        {
            Console.WriteLine("=== Value Type (int) ===");
            int numberOne = 10;
            int numberTwo = numberOne;
            numberTwo = 20;

            Console.WriteLine($"numberOne: {numberOne}"); // 10
            Console.WriteLine($"numberTwo: {numberTwo}"); // 20

            Console.WriteLine("=== Reference Type (class) ===");
            Person x = new Person { Name = "Ahmet" };
            Person y = x;
            y.Name = "Mehmet";

            Console.WriteLine($"x.Name: {x.Name}"); // Mehmet
            Console.WriteLine($"y.Name: {y.Name}"); // Mehmet
        }

        class Person
        {
            public string? Name { get; set; }
        }
    }
}
/*
        --- NEDEN BÖYLE OLDU? ---
    Value type ve Reference type diyeceğimiz iki type var. Bunların çalışma mantığı birbirinden biraz farklı.
    Values typelar stack üzerinde tutulur bu yüzden numberTwo değişince numberOne'ın değerinde bir değişiklik olmuyor.
    Reference typelarda ise durum farklı. Adından da anlaşılacağı üzere burada referenceları ile çalışıyoruz.
    Reference type stackde referansını tutar değer heap de tutulur o yüzden Person y = x; dediğimizde y ve x değerlerinin referansları aynı oldu.
    y.Name değişince x değişmiş oldu.

    Value Type (int, long, short, byte, sbyte, uint, ulong, ushort, float, double, decimal, float, double, decimal, enum, struct (kendi tanımladığın tüm struct türleri), DateTime, TimeSpan, Guid, DateOnly, TimeOnly, ValueTuple, Nullable<T>(örnek: int?))
    Reference Type (class, object, string*, array, delegate, Action, Func, Predicate, interface, record class (C# 9+), dynamic, collections (List<T>, Dictionary<K,V>, HashSet<T>, Queue<T>))
 */