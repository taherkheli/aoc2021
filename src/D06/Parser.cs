namespace aoc.D06
{
  public class Parser
  {
    public static int[] Parse(string path)
    {
      var lines = File.ReadAllLines(path);
      var numbers_s = lines[0].Split(',');

      var result = new int[numbers_s.Length];

      for (int i = 0; i < numbers_s.Length; i++)      
        result[i] = int.Parse(numbers_s[i].Trim());
      
      return result;
    }
  }
}
