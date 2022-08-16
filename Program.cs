using System;
namespace arraysınıfmetodları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayıDizisi={23,12,86,72,3,11,17};
            //Sırasız Liste
            Console.WriteLine("Sırasız Liste");
            foreach(var sayi in sayıDizisi)
                Console.WriteLine(sayi);

            //Sıralı Liste
            Console.WriteLine("Sıralı Liste");
            Array.Sort(sayıDizisi);
            foreach(var sayi in sayıDizisi)
                Console.WriteLine(sayi);
            
            //Clear
            Console.WriteLine("Array Clear");
            //Sayı dizisi elemanlarını kullanrak 2.index ten itibaren 2 tanee elemanı siliyor
            Array.Clear(sayıDizisi,2,2);
            foreach(var sayi in sayıDizisi)
                Console.WriteLine(sayi);


            //İnverse
            Console.WriteLine("İnverse");
            Array.Reverse(sayıDizisi);
            foreach(var sayi in sayıDizisi)
                Console.WriteLine(sayi);
            

            //İndex Of
            Console.WriteLine("Array Indexof");
            Console.WriteLine(Array.IndexOf(sayıDizisi,23));
            
            //Resize
            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayıDizisi,9);
            sayıDizisi[8]=99;

            foreach(var sayi in sayıDizisi)
                Console.WriteLine(sayi);



        }
    }
}
