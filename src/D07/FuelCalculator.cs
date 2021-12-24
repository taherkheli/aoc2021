namespace aoc.D07
{
  public static class FuelCalculator
  {
    public static int Calculate(int[] positions, bool partII = false)
    {
      var minFuel = int.MaxValue;

      for (int i = 0; i < positions.Length; i++)
      {
        var tempFuel = 0;
        var update = true;

        for (int j = 0; j < positions.Length; j++)
        {
          var steps = Math.Abs(positions[j] - i);
          var fuel = 0;

          if (partII)
          {
            for (int k = steps; k > 0; k--)
              fuel += k;
          }
          else
          {
            fuel = steps;
          }

          tempFuel += fuel;

          if (tempFuel > minFuel)
          {
            update = false;
            break;
          }
        }

        if (update)
          minFuel = tempFuel;
      }

      return minFuel;
    }
  }
}
