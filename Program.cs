using System;

namespace c_
{
  class Program 
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      double[] unsortedList = new double[10];

      for (int i = 0; i < unsortedList.Length; i++)
      {
        unsortedList.SetValue(random.Next(), i);
      }
    
      BubbleSort(unsortedList);
    }

    public static void BubbleSort(double[] unsortedList)
      {
        string stringInitialMiliseconds = DateTime.Now.ToString("hhmmssfff");
        int initialMiliseconds = Int32.Parse(stringInitialMiliseconds);

        double temp;

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

        string stringFinalMilliseconds = DateTime.Now.ToString("hhmmssfff");
        int finalMilliseconds = Int32.Parse(stringFinalMilliseconds);

        int final = finalMilliseconds - initialMiliseconds;
        
        string result = Convert.ToString(final);

        if (final >= 1000)
        {
          string resultInSeconds = Convert.ToString(final / 1000);

          if (Int32.Parse(resultInSeconds) >= 60)
          {
            string resultInMinutes = Convert.ToString(Int32.Parse(resultInSeconds) / 60);

            Console.WriteLine(resultInMinutes + "min" + " ou " + resultInSeconds + "sec");
          }

          Console.WriteLine(resultInSeconds + "sec" + " ou " + final + "ms");
        } else
        {
          Console.WriteLine(result + "ms");
        }
      }
  }
}
