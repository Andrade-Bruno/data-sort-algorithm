using System;

namespace SelectionSortNamespace
{
  class SelectionSort
  {
    public string handleAlgorithm(int[] unsortedList)
    {
      Random random = new Random();

      if (unsortedList.Length > 1)
      {
        string stringInitialMoment = DateTime.Now.ToString("hhmmssfff");
        int initialMoment = Int32.Parse(stringInitialMoment);

        for (int i = 0; i < unsortedList.Length; i++)
        {
          unsortedList.SetValue(random.Next(), i);
        }

        handleSelectionSort(unsortedList);

        string stringFinalMoment = DateTime.Now.ToString("hhmmssfff");
        int finalMoment = Int32.Parse(stringFinalMoment);

        int milliseconds = finalMoment - initialMoment;
        string stringMilliseconds = Convert.ToString(milliseconds);

        Console.WriteLine("SelectionSort:");

        if (milliseconds >= 1000)
        {
          string resultInSeconds = Convert.ToString(milliseconds / 1000);

          if (Int32.Parse(resultInSeconds) >= 60)
          {
            string resultInMinutes = Convert.ToString(Int32.Parse(resultInSeconds) / 60);

            return resultInMinutes + "min" + " ou " + resultInSeconds + "sec";
          }

          return resultInSeconds + "sec" + " ou " + milliseconds + "ms";
        }
        else
        {
          return stringMilliseconds + "ms";
        }
      }
      else
      {
        return "O tamanho da lista deve ser maior que 1.";
      }
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