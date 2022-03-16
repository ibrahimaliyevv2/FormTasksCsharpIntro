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

            #region Form-Task3
            // Verilmis n ededinden m ededine qeder olan ededlerin cemini tapmali


            //int sum = 0;
            //for (int i = 2; i <5; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Form-Task4
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
            #endregion

            #region Form-Task5
            //Ededin reqemleri cemini tapmali

            //int num = 123;
            //int sum = 0;

            //while (num != 0)
            //{
            //    sum += num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Form-Task6
            // 1 eded verilir. Eger o eded 50den kicikdirse o edede qeder 3-e bolunen,
            // 50-100 araligindadirsa o edede qeder 5e bolunen,
            // 100den boyukdurse o edede qeder 8 e bolunen ededlerin sayini ekrana cixardan bir alqoritm yazin.

            //Console.WriteLine("Ededi daxil edin:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    if (num < 50)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            count++;
            //        } 
            //    }

            //    if(num>50 && num < 100)
            //    {
            //        if (i % 5 == 0)
            //        {
            //            count++;
            //        }
            //    }

            //    if (num > 100)
            //    {
            //        if (i % 8 == 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("cavab:"+count);
            #endregion

            #region Form-Task7
            // Calculator

            //Console.WriteLine("Enter first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine()); ;
            //Console.WriteLine("Type operation");
            //char operation = Convert.ToChar(Console.ReadLine());
            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            //        break;
            //    case '-':
            //        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 -num2));
            //        break;
            //    case '*':
            //        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 *num2));
            //        break;
            //    case '/':
            //        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 /num2));
            //        break;
            //    default:
            //        Console.WriteLine("Wrong operation");
            //        break;
            //}
            #endregion

            #region Form-Task8
            // Adlar siyahisinda a herfi ile baslayan adlari consola yazdir(cap et)


            //string[] schedule = { "Asif", "Vasif", "Agasif" };

            //for (int i = 0; i < schedule.Length; i++)
            //{
            //    if(schedule[i][0] == 'A')
            //    {
            //        Console.WriteLine(schedule[i]);
            //    }
            //}
            #endregion

            #region Form-Task9
            // Adlar siyahisinda a herfi ile baslayan adlari massive yigaraq cap et

            string[] schedule = { "Asif", "Vasif", "Agasif" };
            int count = 0;


            for (int i = 0; i < schedule.Length; i++)
            {
                if (schedule[i][0] == 'A')
                {
                    count++;
                }
            }
                string[] newSchedule = new string[count];
                int j = 0;
                for (int i = 0; i < schedule.Length; i++)
                {
                    if (schedule[i][0] == 'A')
                    {
                        newSchedule[j] = schedule[i];
                        j++;
                    }

                }

                foreach(var item in newSchedule)
                {
                    Console.WriteLine(item);
                }

            #endregion

        }
    }
    }