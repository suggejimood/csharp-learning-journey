# 🧠 C# Learning Journey by Mehmet Tan

Bu repo, C# diline temelden başlayıp en ileri seviye detaylara kadar adım adım öğrenmeyi hedefleyenler içindir.  
Kodun nasıl yazıldığından önce, neden öyle yazıldığını anlamaya odaklanır.  
Bellek modelinden, fonksiyonel yapıya; string’lerden unsafe programlamaya kadar tüm C# yolculuğu bu proje altında inşa edilecektir.

> — Mehmet Tan

---

## 🚀 Roadmap: Öğrenme Aşamaları

### 📦 1. Bellek ve Tip Sistemi
- Stack vs Heap
- Value Type vs Reference Type
- Nullable types (`int?`, `Nullable<T>`)
- Boxing & Unboxing
- `ref`, `out`, `in` parametre farkları
- `readonly struct`, `record struct`, `ref struct`
- `Span<T>`, `stackalloc`, `Memory<T>`, `ReadOnlySpan<T>`
- Memory layout, `StructLayout`, `FieldOffset`

### 🔢 2. Veri Tipleri (Tam Kapsam)
- Tüm primitive tipler (`int`, `long`, `float`, vb.)
- `enum`, `flag enum`, bit mask yapıları
- `object`, `dynamic`, `var`, `nameof`, `typeof`, `sizeof`, `default`
- `Tuple`, `ValueTuple`, `record` ve deconstruction

### 🔡 3. String Sistemi & Regex
- `string` immutable yapısı ve intern pool
- 60+ metot: `Trim`, `Replace`, `Split`, `Join`, vb.
- `StringBuilder` kullanımı ve performans örnekleri
- `Span<char>` ile karşılaştırma
- `Regex`, `RegexOptions`, regex engine farkları

### ➗ 4. Matematik ve System.Numerics
- `System.Math`, `MathF` – 30+ fonksiyon
- `System.Numerics.Vector<T>` – SIMD, AVX/SSE
- `System.Numerics.Complex`, `BigInteger`
- `System.Runtime.Intrinsics` – `Vector128<T>`, `Vector256<T>`

### 🔁 5. Operatörler ve Koşullar
- Arithmetic, logical, comparison, bitwise
- Null coalescing: `??`, `??=`, null conditional `?.`
- Pattern matching: `is`, `switch`, `when`, property/relational patterns
- `goto`, `label`, `continue`, `break`

### 🔄 6. Döngüler ve İterasyon
- `for`, `while`, `do-while`, `foreach`
- `IEnumerator<T>` mantığı
- `yield return` ve generator yapıları

### 📊 7. Diziler ve Koleksiyonlar
- Tek boyutlu, çok boyutlu, jagged array’ler
- `Array.Clear`, `Array.IndexOf`, `Array.Resize`, vb.
- `List<T>`, `Queue<T>`, `Stack<T>`, `Dictionary<K,V>`, `HashSet<T>`
- `ImmutableList<T>` ve `System.Collections.Immutable`
- `ArrayPool<T>`, `stackalloc`, `Span<T>` ile GC-free diziler

### 🧰 8. Metotlar ve Fonksiyonel Yapılar
- `static`, overload, optional, named args
- `ref`, `out`, `in`, `params`, discard (`_`)
- `Func`, `Action`, `Predicate`, `Delegate`
- Anonymous method, lambda, closure
- Local function vs anonymous delegate
- Recursive ve tail recursion örnekleri

### 🧱 9. System Namespace Kütüphaneleri
- `Console`, `Environment`, `DateTime`, `Stopwatch`, `Random`
- `Convert`, `BitConverter`
- `System.IO`, `Stream`, `MemoryStream`
- `System.Diagnostics`, `Thread`, `Task`, `CancellationToken`
- `System.IO.Pipelines`, `Buffer<T>`, `Memory<T>`

### 🧪 10. Test & Hata Ayıklama
- `Debug.Assert`, `Trace.WriteLine`, `Contract`
- `Visual Studio Test Explorer` kullanımı
- Her konuya özel edge case test senaryoları

### 🧬 11. Unsafe Kodlama & Pointer
- `unsafe` blok, `int*`, `byte*`, `void*`
- `fixed` keyword, pointer aritmetiği
- `stackalloc`, `sizeof`, `&`, pointer casting
- Native buffer yapıları, `Span<T>` vs pointer performansları

---

## 🏁 Hedef

Bu repo tamamlandığında:
- C#’ın iç mimarisini anlayabilecek,
- Derinlikli yazılım mimarileri kurabilecek,
- Senior düzey backend development için sağlam bir temel oluşturmuş olacaksın.

---

## 📚 Not

Her klasör bir modül, her `.cs` dosyası tek bir konuya ait örnekler ve açıklamalar içerir.  
Kodlar modern C# standardına göre yazılmıştır (C# 10+).  
IDE önerisi: **Visual Studio 2022** veya **Rider**.

---

İyi çalışmalar ve sağlıklı günler dilerim
