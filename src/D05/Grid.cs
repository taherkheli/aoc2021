namespace aoc.D05
{
  public class Grid
  {
    private List<Line> _lines;
    private List<Line> _linesOfInterest;
    private List<Point> _gridPoints;

    public Grid(List<Line> lines)
    {
      _lines = lines;
      _linesOfInterest = new List<Line>();
      _gridPoints = new List<Point>();
      GetLinesofInterest();
    }

    public int PartI()
    {
      int count = 0;

      //draw
      foreach (var line in _linesOfInterest)
      {
        bool horizontal = (line.Start.Y == line.End.Y);
        bool vertical = (line.Start.X == line.End.X);

        if (horizontal)  //y is constant
        {
          var xMin = Math.Min(line.Start.X, line.End.X);
          var xMax = Math.Max(line.Start.X, line.End.X);

          for (int i = xMin; i < xMax + 1; i++)
            Process(i, line.Start.Y);          
        }
        else if (vertical) //x is constant
        {
          var yMin = Math.Min(line.Start.Y, line.End.Y);
          var yMax = Math.Max(line.Start.Y, line.End.Y);

          for (int i = yMin; i < yMax + 1; i++)
            Process(line.Start.X, i);
        }
      }

      //count
      foreach (var p in _gridPoints)
        if (p.DrawnCount > 1)
          count++;

      return count;
    }

    private void GetLinesofInterest()
    {
      //isolate lines of interest
      foreach (var line in _lines)
        if ((line.Start.X == line.End.X) || (line.Start.Y == line.End.Y))
          _linesOfInterest.Add(line);
    }

    //if a point with these coords exists udpate count otherwise add n update count
    private void Process(int x, int y)
    {
      var index = _gridPoints.FindIndex(p => ((p.X == x) && (p.Y == y)));
      if (index != -1)
      {
        _gridPoints[index].DrawnCount++;
      }
      else
      {
        var p = new Point(x, y);
        p.DrawnCount++;
        _gridPoints.Add(p);
      }
    }
  }
}
