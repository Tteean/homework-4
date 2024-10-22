using System.Collections.Immutable;

namespace arrays_homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1


            //int[] array = { 1, 50, 30, 29, 40 };
            //int sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];

            //}
            //Console.WriteLine(sum);


            #endregion
            #region Task2
            int[] numbers = { 1, 10, 30, 29, 40 };
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] > numbers[j+1])
                    {
                        count += numbers[i];
                    }
                    else
                    {
                        count += 0;
                    }

                }

            }
            Console.WriteLine(count);


            #endregion

            #region Task3

            //int[] numbers = { 9, 10, 30, 29, 40, 60 };
            //int a = numbers.Length - 1;

            //Console.WriteLine(numbers[0] + numbers[a]);


            #endregion

            #region Task4

            //int n = 72;

            //while (n > 1)
            //{
            //    n /= 2;

            //}
            //if (n == 1)
            //{
            //    Console.WriteLine("2-nin quvvetidir");
            //}
            //else
            //{
            //    Console.WriteLine("2-nin quvveti deyil");
            //}
            #endregion

            #region Task5

            //int n = 23452;
            //int count = 0;

            //while (n > 0)
            //{
            //    n /= 10;
            //    count++;
            //}
            //Console.WriteLine(count);

            #endregion

            #region Task6

            //int[] numbers = { 1, 10, 20, 30, 40, 50 };
            //int count = 0;

            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    if (numbers[i] == 40)
            //    {
            //        break;
            //    }
            //    count++;

            //}
            //if (count == numbers.Length)
            //{
            //    Console.WriteLine("-1");
            //}
            //else
            //{
            //    Console.WriteLine(count);
            //}

            #endregion
        }

    }
}