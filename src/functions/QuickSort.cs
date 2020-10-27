using System;
using Utils;
using Constants;

namespace Functions
{
  class QuickSort
  {
    FillRandomValues fill = new FillRandomValues();
    Error errors = new Error();
    Time time = new Time();
    public string handleRunningQuickSort(int[] unsortedList, int startInterval, int finalInterval, bool show)
    {
      if (unsortedList.Length <= 1) return errors.getSizeError();

      fill.handleList(unsortedList, startInterval, finalInterval);
        
      string result = time.handleRuntime(handleQuickSort, unsortedList);

      Console.WriteLine("Quick Sort in " + unsortedList.Length + " numbers:");

      if (show)
      {
        Console.WriteLine(string.Join(", ", unsortedList));
      }

      return result;
    }

    public void handleQuickSort(int[] unsortedList)
    {
      quickSort(unsortedList, 0, unsortedList.Length - 1);
    }

    public void quickSort(int[] unsortedList, int leftStart, int rightEnd)
    {
      int i = leftStart;
      int j = rightEnd;

      int pivot = unsortedList[(leftStart + rightEnd) / 2];

      while (i <= j)
      {
        while (unsortedList[i] < pivot)
        {
          i++;
        }

        while (unsortedList[j] > pivot)
        {
          j--;
        }

        if (i <= j)
        {
          int temp = unsortedList[i];
          unsortedList[i] = unsortedList[j];
          unsortedList[j] = temp;

          i++;
          j--;
        }
      }

      if (leftStart < j)
        quickSort(unsortedList, leftStart, j);

      if (i < rightEnd)
        quickSort(unsortedList, i, rightEnd);
    }
  }
}