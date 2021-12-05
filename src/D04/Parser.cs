namespace aoc.D04
{
  public class Parser
  {
    public static (List<int>, List<Board>) Parse(string path)
    {
      var numbers = new List<int>();
      var boards = new List<Board>();

      var lines = File.ReadAllLines(path);
      var numbers_s = lines[0].Split(',');

      foreach (var s in numbers_s)
        numbers.Add(Int32.Parse(s));

      int rows = 5;
      var line_num = 1;

      while (line_num < lines.Length)
      {
        line_num++;

        List<List<Point>> points = new List<List<Point>>();
        List<Point> row = new List<Point>();

        for (int i = 0; i < rows; i++)
        {
          row = new List<Point>();
          var element_s = lines[line_num].Split(' ');

          foreach (var e in element_s)
          {
            if (e != "")
              row.Add(new Point(Int32.Parse(e), false));
          }

          if (row.Count > 0)
            points.Add(row);

          line_num++;
        }

        boards.Add(new Board(points));
      }

      return (numbers, boards);
    }
  }
}
