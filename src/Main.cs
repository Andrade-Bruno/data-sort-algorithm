using System;
using Functions;

namespace Run
{
  class Main
  {
    BubbleSort bubbleSort = new BubbleSort();
    SelectionSort selectionSort = new SelectionSort();
    QuickSort quickSort = new QuickSort();
    Random random = new Random();
    public void showConsole(int size, int startInterval = -1, int finalInterval = -1, bool show = false)
    {
      int[] selectionList = new int[size];
      int[] quickList = new int[size];
      int[] bubbleList = new int[size];

      if (startInterval == -1) startInterval = random.Next();
      if (finalInterval == -1) finalInterval = random.Next();

      while (true)
      {
        int tecla = int.Parse(Console.ReadLine());

        if (tecla == 4) {
          Console.WriteLine("\nStarting Selection Sort...\n");
          string selection = selectionSort.handleRunningSelectionSort(selectionList, startInterval, finalInterval, show);
          Console.WriteLine(selection);
        }

        if (tecla == 5) {
          Console.WriteLine("\nStarting Bubble Sort...\n");
          string bubble = bubbleSort.handleRunningBubbleSort(selectionList, startInterval, finalInterval, show);
          Console.WriteLine(bubble);
        }

        if (tecla == 6) {
          Console.WriteLine("\nStarting Quick Sort...\n");
          string quick = quickSort.handleRunningQuickSort(selectionList, startInterval, finalInterval, show);
          Console.WriteLine(quick);
        }
    }
  }
}
