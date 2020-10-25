using System;

namespace BubbleSortNamespace
{
  class BubbleSort
  {
    public string handleAlgorithm(int[] unsortedList)
      {
        Random random = new Random();

        if (unsortedList.Length > 1)
        {
          for (int i = 0; i < unsortedList.Length; i++)
          {
            unsortedList.SetValue(random.Next(), i);
          }

        string stringInitialMoment = DateTime.Now.ToString("hhmmssfff");
        int initialMoment = Int32.Parse(stringInitialMoment);

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

        string stringFinalMoment = DateTime.Now.ToString("hhmmssfff");
        int finalMoment = Int32.Parse(stringFinalMoment);

        int milliseconds = finalMoment - initialMoment;
        string stringMilliseconds = Convert.ToString(milliseconds);

        Console.WriteLine("BubbleSort: ");

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
  }
}