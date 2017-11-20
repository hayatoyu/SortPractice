using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortPractice
{
    class SortingPractice
    {
        #region 氣泡排序法
        public static void BubbleSort<T> (ref T[] array) where T : IComparable<T>
        {
            T temp;
            bool swap;
            for(int i = 0;i < array.Length;i++)
            {
                swap = false;
                for(int j = 0;j < array.Length - i - 1;j++)
                {
                    if(array[j].CompareTo(array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        if (!swap)
                            swap = true;
                    }
                }
                if (!swap)
                    return;
            }

        }

        #endregion

        #region 插入排序法
        public static void InsertionSort<T> (ref T[] array) where T : IComparable<T>
        {
            for(int i = 1;i < array.Length;i++)
            {
                T t = array[i];
                for(int j = i - 1;j >= 0;j--)
                {                    
                    if (array[j].CompareTo(t) > 0)
                    {
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
        }
        #endregion

        #region 合併排序法

        public static void MergeSort<T> (ref T[] array) where T : IComparable<T>
        {
            array = Divide(array.ToList()).ToArray();            
        }

        private static List<T> Divide<T> (List<T> list) where T : IComparable<T>
        {
            if (list.Count <= 1)
                return list;
            int mid = list.Count / 2;

            var left = list.GetRange(0, mid);
            var right = list.GetRange(mid, list.Count - mid);

            left = Divide(left);
            right = Divide(right);

            return Merge(left, right);
            
        }
        private static List<T> Merge<T> (List<T> left,List<T> right) where T : IComparable<T>
        {
            List<T> temp = new List<T>();
            while(left.Count > 0 && right.Count > 0)
            {
                if(left[0].CompareTo(right[0]) > 0)
                {
                    temp.Add(right[0]);
                    right.RemoveAt(0);
                }
                else
                {
                    temp.Add(left[0]);
                    left.RemoveAt(0);
                }
            }
            if (left.Count > 0)
                temp.AddRange(left);
            else if (right.Count > 0)
                temp.AddRange(right);
            return temp;
        }

        #endregion

        #region 快速排序法
        public static void QuickSort<T>(ref T[] array) where T : IComparable<T>
        {
            array = QuickSort(array.ToList()).ToArray();
        }
        private static List<T> QuickSort<T>(List<T> list) where T : IComparable<T>
        {
            if (list.Count < 2)
                return list;

            List<T> less = new List<T>();
            List<T> greater = new List<T>();
            List<T> result = new List<T>();
            T pivot = list[list.Count / 2];
            list.RemoveAt(list.Count / 2);

            foreach(T t in list)
            {
                if (pivot.CompareTo(t) > 0)
                    less.Add(t);
                else
                    greater.Add(t);
            }
            result.AddRange(QuickSort(less));
            result.Add(pivot);
            result.AddRange(QuickSort(greater));
            return result;
        }
        #endregion
    }
}
