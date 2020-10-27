using System;

namespace Utils
{
  class Time
  {
    int milliseconds;
    int seconds;
    int minutes;

    public string handleRuntime(Action<int[]> handleSort, int[] unsortedList)
    {
      int initialMoment = Int32.Parse(DateTime.Now.ToString("hhmmssfff"));

      handleSort(unsortedList);

      int finalMoment = Int32.Parse(DateTime.Now.ToString("hhmmssfff"));

      int milliseconds = finalMoment - initialMoment;

      if (milliseconds >= 1000) {
        int seconds = handleSeconds(milliseconds);

        if (seconds >= 60)
        {
          int minutes = handleMinutes(milliseconds);

          return Convert.ToString(minutes) + "min" + " ou " + seconds + "sec";
        }

        return Convert.ToString(seconds) + "sec" + " ou " + milliseconds + "ms";
      }
      else
      {
        return Convert.ToString(milliseconds) + "ms";
      }
    }

    public int handleMilliseconds(int milliseconds)
    {
      this.milliseconds = milliseconds;
    
      return milliseconds;
    }

    public int handleSeconds(int milliseconds)
    {
      this.seconds = milliseconds / 1000;

      return seconds;
    }

    public int handleMinutes(int milliseconds)
    {
      this.minutes = milliseconds / 60000;

      return minutes;
    }
  }
}
