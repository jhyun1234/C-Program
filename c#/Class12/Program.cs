namespace Class12
{
    internal class Program
    {
        static void QuickSort(int[] array, int start, int end)
        {
            // 1. left가 right보다 크거나 같아졌을 때
            if (start >= end)
            {
                return;
            }

            // 2. pivot 변수의 값을 설정한다.
            int pivot = start;

            // 3. left 변수의 값을 설정한다.
            int left = start + 1;

            // 4. right 변수의 값을 설정한다.
            int right = end;

            // 5.left가 right보다 크거나 같을때 까지 반복한다.
            while (left <= right)
            {
                // 6. left가 end보다 작거나 같다면 반복하도록 실행하고 
                //    pivot 값보다 left의 값이 작을 때 left을 오른쪽으로 이동시킨다.
                while (left <= end && array[pivot] >= array[left])
                {
                    left++;
                }
                // 6. right가 start보다 크다면 반복하도록 실행하고 
                //    pivot 값보다 right의 값이 클 때 right을 왼쪽으로 이동시킨다.
                while (right > start && array[pivot] <= array[right])
                {
                    right--;
                }

                if (left > right)
                {
                    Swap(ref array[pivot], ref array[right]);
                }
                else
                {
                    Swap(ref array[left], ref array[right]);
                }
            }
            // 왼쪽 분할 정복재귀 함수
            QuickSort(array, start, right - 1);

            // 오른쪽 분할 정복 재귀 함수
            QuickSort(array, right + 1, end);


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
            int[] array = new int[10] { 3, 1, 2, 5, 4, 6, 7, 8, 11, 10 };

            QuickSort(array, 0, array.Length - 1);

            foreach (int x in array)
            {
                Console.Write(" " + x);
            }
            #endregion

        }
    }
}