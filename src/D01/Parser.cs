namespace aoc.D01
{
  public static class Parser
  {
    public static int[] Parse(string path)
    {
      var lines = File.ReadAllLines(path);
      var measurements = new int[lines.Length];

      for (var i = 0; i < lines.Length; i++)
        measurements[i] = int.Parse(lines[i].Trim());

      return measurements;
    }
  }
}
