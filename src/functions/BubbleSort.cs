using System;
using Utils;
using Constants;

namespace Functions
{
  class BubbleSort
  {
    FillRandomValues fill = new FillRandomValues();
    Error errors = new Error();
    Time time = new Time();

    public string handleRunningBubbleSort(int[] unsortedList, int startInterval, int finalInterval, bool show)
    {
      if (unsortedList.Length <= 1) return errors.getSizeError();

      fill.handleList(unsortedList, startInterval, finalInterval);
        
      string finalTime = time.handleRuntime(handleBubbleSort, unsortedList);

      Console.WriteLine("Bubble Sort in " + unsortedList.Length + " numbers:");

      if (show)
      {
        Console.WriteLine(string.Join(", ", unsortedList));
      }

      return finalTime;
    }
  
    public void handleBubbleSort(int[] unsortedList)
    {
      int temp;

      for (int i = 0; i < unsortedList.Length - 1; i++)
      {
        for (int j = 0; j < unsortedList.Length - (1 + i); j++)
        {
          if (unsortedList[j] > unsortedList[j + 1])
          {
            temp = unsortedList[j + 1];

            unsortedList[j + 1] = unsortedList[j];
            unsortedList[j] = temp;
          }
        }
      }

      return ;
    }
  }
}