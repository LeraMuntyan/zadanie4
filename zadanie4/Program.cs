using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {



            Random rand = new Random();
            int n = 20;
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 11);
                Console.Write("{0,3} ", i);
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                    arr[i] = rand.Next(1, 10);
                else
                    arr[i] = rand.Next(-9, 0);

                Console.Write("{0,3} ", arr[i]);
            }
            int o = arr[0];
            arr[0] = arr[n - 1];
            arr[n - 1] = o;

            for (int i = 1, j = i + 1; i < arr.Length - 2; i += 2, j += 2)
            {
                o = arr[i];
                arr[i] = arr[j];
                arr[j] = o;
            }

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,3} ", arr[i]);
            }
            Console.WriteLine();

            {
                Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
            Console.ReadLine();
        }
    }
}
