using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp._00_memory_basics
{
    internal class BoxingUnboxing
    {
        public static void Run() 
        {

            Console.WriteLine("=== Boxing: Value Type -> Reference Type ===");
            int number = 27;
            object boxed = number; //Boxing işlemi
            Console.WriteLine($"Boxed: {boxed}");//27

            Console.WriteLine("=== Unboxing: Reference Type -> Value Type ===");
            object obj = 1881;
            int unboxed = (int)obj;
            Console.WriteLine($"Unboxed: {unboxed}"); //1881

            Console.WriteLine("=== Orjinal değer değişince boxed değişmez ===");
            number = 10;
            Console.WriteLine($"Original number: {number}"); //10
            Console.WriteLine($"Previously boxed: {boxed}"); //27

            Console.WriteLine("=== Invalid Unboxing ===");

            try
            {
                object wrong = "hello";
                int fail = (int)wrong;  // HATA: string -> int unboxing yapılamaz
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Unboxing Error: {ex.Message}"); //Unboxing Hatası
            }
        }
    }
}

/*
 *          Nedir Bu Boxing Unboxing?
 * 
 * Boxing: Bir Value Type değerini Reference Type içine alarak, stack üzerinden heap'e taşıma işlemidir.
 * Unboxing: Bu işlem ise Reference Type içinde bulunan değeri exlicit cast yaparak heap üzerinden stack'e taşımadır.
 * 
 * Peki ne için kullanılır?
 * Bu işlem çoğu zaman arkada otomatik olarak gerçekleşir.
 * object tipli colectionlardan value type tutmak için. (Eski C# sürümlerinde ArrayList, Hashtable hep object kullanılırdı).
 * API'lerde türü bilinmeyen genel değeri tutmak.
 * Generic olmayan yapılarda type abstraction için kullanılır.
 * 
 * NOT: Boxing (int -> object) heap kopyası, unboxing (object -> int) cast + stack'e taşıma ilemi olur bu da GC yükü + casting maliyeti getirir. Döngülerde çok yapılırsa performans problemleri yaşanabilir.
 * Modern C# çok karşımıza çıkmaz ama bilmekte yarar var.
 */