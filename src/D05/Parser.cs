namespace aoc.D05
{
  public class Parser
  {
    public static List<Line> Parse(string path)
    {
      var linesList = new List<Line>();
      var lines = File.ReadAllLines(path);

      foreach (var line in lines)
      {
        var s        = line.Split(" -> ");
        var start_s  = s[0].Split(',');
        var end_s    = s[1].Split(',');

        var start = new Point(int.Parse(start_s[0]), int.Parse(start_s[1]));
        var end   = new Point(int.Parse(end_s[0]), int.Parse(end_s[1]));
        linesList.Add(new Line(start, end));
      }

      return linesList;
    }
  }
}
