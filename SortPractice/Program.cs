using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 8, 10, 2, 7, 5, 9, 6, 78, 56, 34 };
            string[] b = new string[] { "Alex", "Bob", "Eric", "David", "Tina", "Judy", "Leo", "Mike" };

            #region 氣泡排序法
            // ========== BubbleSort Test ==========
            Console.WriteLine("氣泡排序法測試");
            int[] b_a = new int[11];
            a.CopyTo(b_a, 0);
            string[] b_b = new string[8];
            b.CopyTo(b_b, 0);
            SortingPractice.BubbleSort(ref b_a);
            for (int i = 0; i < b_a.Length; i++)
                Console.Write(b_a[i] + "\t");
            Console.Write("\n");
            SortingPractice.BubbleSort(ref b_b);
            for (int i = 0; i < b_b.Length; i++)
                Console.Write(b_b[i] + "\t");
            Console.Write("\n請按任意鍵繼續");
            Console.ReadLine();

            #endregion


            #region 插入排序法
            // ========== Insertion Test ==========
            Console.WriteLine("插入排序法測試");
            int[] i_a = new int[11];
            a.CopyTo(i_a, 0);
            string[] i_b = new string[8];
            b.CopyTo(i_b, 0);
            SortingPractice.InsertionSort(ref i_a);
            for (int i = 0; i < i_a.Length; i++)
                Console.Write(i_a[i] + "\t");
            Console.Write("\n");
            SortingPractice.InsertionSort(ref i_b);
            for (int i = 0; i < i_b.Length; i++)
                Console.Write(i_b[i] + "\t");
            Console.Write("\n請按任意鍵繼續");
            Console.ReadLine();
            #endregion
        }
    }
}
