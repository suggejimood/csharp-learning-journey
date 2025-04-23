using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp._00_memory_basics
{
    internal class RefOutInParameters
    {
        public static void Run()
        {
            Console.WriteLine("=== ref keyword ===");
            int a = 10;
            ModifyWithRef(ref a);
            Console.WriteLine($"a (after ref): {a}"); //20

            Console.WriteLine("=== out keyword ===");
            int b;
            InitializeWithOut(out b);
            Console.WriteLine($"b (after out): {b}"); //100

            Console.WriteLine("=== in keyword ===");
            int c = 5;
            ReadOnlyWithIn(in c);
            Console.WriteLine($"c (after in): {c}"); //5 (değişmez!)
        }

        static void ModifyWithRef(ref int value)
        {
            value += 10;
        }

        static void InitializeWithOut(out int value)
        {
            value = 100;
        }

        static void ReadOnlyWithIn(in int value)
        {
            Console.WriteLine($"value (in): {value}");
            // value = 99; Error: in ile gelen değişken yazılamaz
        }
    }
}

/*
 *          Ref Out In Nedir?
 * REF: Değeri önceden atanmış olmalı. Çağırlıdığı fonksiyon içerisinde stack üzerinde işlem yapılarak değer değişir. 
 * OUT: Değeri fonksiyon içerisinde belirtilir. Ref'e benzer ama başta değer gerekmez.
 * IN: Değeri sadece okur. Değişiklik yapamaz.
 * 
 * Neden kullanılır: Performans kaygısından dolayı tercih edilir ve birden çok değer dışarıya taşınabilir. Doğal olarak değer döndürmeye alternatif bir seçenek olarakda değerlendirilebilir. 
 * Back End tarafında çok fazla karşımıza çıkmaz oyun motorları, simülasyon gibi yerlerde memory yönetimi için kullanılır. Ayrıca IoT projelerinde bazen stackden fazla yer kullanmasın diyede tercih edilebilir.
 * ref -> gerçek bellek erişimi.
 * out -> daha az yaygın ama parsing/tür dönüşümlerinde karşımıza çıkabilir.
 * in -> Performans dostu modern C# 
 */