namespace Constants
{
  class Error
  {
    private string sizeError;

    public string getSizeError()
    {
      this.sizeError = "The list size must be greater than 1.";

      return sizeError;
    }
  }
}
