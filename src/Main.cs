using System;

namespace MainNamespace
{
  class Main
  {
    public void handleBubbleSort(int[] unsortedList)
    {
      BubbleSortNamespace.BubbleSort bubbleSort = new BubbleSortNamespace.BubbleSort();

      Console.WriteLine(bubbleSort.handleAlgorithm(unsortedList));
    }
  
    public void handleSelectionSort(int[] unsortedList)
    {
      SelectionSortNamespace.SelectionSort selectionSort = new SelectionSortNamespace.SelectionSort();

      Console.WriteLine(selectionSort.handleAlgorithm(unsortedList));
    }
  }
}
