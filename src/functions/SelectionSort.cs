using System;
using Utils;
using Constants;

namespace Functions
{
  class SelectionSort
  {
    Random random = new Random();
    Error errors = new Error();
    FillRandomValues fill = new FillRandomValues();
    Time time = new Time();

    public string handleRunningSelectionSort(int[] unsortedList, int startInterval, int finalInterval, bool show)
    {
      if (unsortedList.Length <= 1) return errors.getSizeError();

      fill.handleList(unsortedList, startInterval, finalInterval);
        
      string result = time.handleRuntime(handleSelectionSort, unsortedList);

      Console.WriteLine("Selection Sort in " + unsortedList.Length + " numbers:");

      if (show)
      {
        Console.WriteLine(string.Join(", ", unsortedList));
      }

      return result;
    }

    public void handleSelectionSort(int[] unsortedList)
    {
      for (int i = 0; i < unsortedList.Length - 1; i++)
      {
        int min = i;

        for (int j = i + 1; j < unsortedList.Length; j++)
        {
          if (unsortedList[j] < unsortedList[min])
          {
            min = j;
          }
        }

        int temp = unsortedList[i];

        unsortedList[i] = unsortedList[min];
        unsortedList[min] = temp;
      }
    }
  }
}