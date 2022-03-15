using System;

namespace FormTasksCsharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Fom-Task1
            // Massivde verilmis ededlerin cemini tapmaq
            //int sum = 0;
            //Console.WriteLine("Massivin olcusunu daxil edin:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //Console.WriteLine("Massivin elementlerini daxil edin:");
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers[i];
            //}
            //Console.WriteLine("Elementlerin cemi:" + sum);
            #endregion


            #region Form-Task2
            // Bir string massivinin icerisinde uzunlugu 5-den boyuk olan sozleri ekrana cixaran alqoritm

            //int i;
            //String[] array = {"zamiq", "banu", "benovse", "azerbaycan", "huseyn" };
            //for (  i = 0; i < 5; i++)
            //{
            //    if (array[i].Length > 5)
            //    {
            //        Console.WriteLine(array[i]);
            //    }
            //}
            #endregion


            // Verilmis n ededinden m ededine qeder olan ededlerin cemini tapmali


            //int sum = 0;
            //for (int i = 2; i <5; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);



            //1-den 100-e qeder 15-e bolunen ededlerin ededi ortasini tapmaq
            //int sum = 0;
            //int count = 0;
            //for(int i =1; i<100; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        sum += i;
            //        count++;
            //    }

            //}
            //Console.WriteLine(sum / count);

            //Ededin reqemleri cemini tapmakli
            int num = 123;
            int sum = 0;

            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
