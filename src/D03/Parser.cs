namespace aoc.D03
{
  public class Parser
  {
    public static string[] Parse(string path)
    {
      return File.ReadAllLines(path); 
    }
  }
}