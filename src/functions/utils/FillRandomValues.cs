using System;

namespace Utils
{
  class FillRandomValues
  {
    Random random = new Random();

    public void handleList(int[] array, int startInterval, int finalInterval)
    {
      if (array.Length <= 1) return;

      for (int i = 0; i < array.Length; i++)
      {
        array.SetValue(random.Next(startInterval, finalInterval), i);
      }
    }
  }
}
