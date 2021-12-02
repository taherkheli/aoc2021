namespace aoc.D01
{
  public class MeasurementsCounter
  {
    public int GetMeasurementsIncreasedCount(int[] measurements, int width = 1)
    {
      int increasedCount = 0;

      if (measurements.Length > width) 
      {
        int last = -1;

        for (int i = 0; i < (measurements.Length - (width - 1)); i++)
        {
          if (i == 0)
            last = GetSum(measurements, width, 0);
          else
          {
            int current = GetSum(measurements, width, i);
            if (current > last)
              increasedCount++;

            last = current;
          }
        }
      }

      return increasedCount;
    }

    //given an array, a number n, and an index to start from, return the sum of the n elements 
    private int GetSum(int[] input, int number, int startIndex)
    {
      int result = 0;

      if (number < input.Length)
      {
        for (int i = startIndex; i < number + startIndex; i++)
          result += input[i];
      }     

      return result;
    }
  }
}