namespace c_
{
  class Program 
  {
    static void Main(string[] args)
    {
      MainNamespace.Main main = new MainNamespace.Main();

      int[] unsortedList = new int[150];

      main.handleBubbleSort(unsortedList);
      main.handleSelectionSort(unsortedList);
    }
  }
}
