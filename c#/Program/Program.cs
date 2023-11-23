﻿using System.Collections;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml;
using System.Xml.Linq;

namespace Program
{
   
    internal class Program
    {
        static void QuickSort(int [] array,int right , int left)
        {
           // 1. left가 right보다 크거나 같아졌을 때
           if(left >= right)
           {
                return;
           }

        }
        static void Swap(ref int x, ref int y)
        {
            int temporary = x;
            x = y;
            y = temporary;

        }

        static void Main(string[] args)
        {
            #region 퀵 정렬
            // 기준점을 획득한 다음 해당 기준점을 기준으로
            // 배열을 나누고 한 쪽에는 기준점보다 작은 항목들이
            // 위치하고 다른 쪽에는 기준점 보다 큰 항목들이 위치한다.

            // 나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여
            // 모든 배열이 기본 배열이 될 때까지 반복하면서 정렬하는 알고리즘이다.

            // 시간 복잡도 : O(log n)
            int[] array = new int[10] { 3, 1, 2, 5, 4,6,7,8,11,10};
            Array.Sort(array);

            BinarySearch(array, 12);
            #endregion

        }
    }
}