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
      Initialize();
    }

    public int PartI()
    {
      int count = 0;
      
      //draw line
      foreach (var line in _linesOfInterest)
      {
        var points = Line.GetPoints(line);

        foreach (var point in points)
        {
          var index = _gridPoints.FindIndex(x => ((x.X == point.X) && (x.Y == point.Y)));
          if (index != -1)
            _gridPoints[index].DrawnCount++;
        }
      }

      //count
      foreach (var p in _gridPoints)
        if (p.DrawnCount > 1)
          count++;

      return count;
    }


    private void Initialize()
    {
      //isolate lines of interest
      foreach (var line in _lines)
        if ((line.Start.X == line.End.X) || (line.Start.Y == line.End.Y))
          _linesOfInterest.Add(line);

      //determine grid dimensions
      var x = _linesOfInterest.OrderBy(l => l.Start.X).ToList();
      var minX_start = Math.Min(x[0].Start.X, x[x.Count - 1].Start.X);
      var maxX_start = Math.Max(x[0].Start.X, x[x.Count - 1].Start.X);

      x = _linesOfInterest.OrderBy(l => l.End.X).ToList();
      var MinX_end = Math.Min(x[0].End.X, x[x.Count - 1].End.X);
      var MaxX_end = Math.Max(x[0].End.X, x[x.Count - 1].End.X);

      var y = _linesOfInterest.OrderBy(l => l.Start.Y).ToList();
      var minY_start = Math.Min(y[0].Start.Y, y[y.Count - 1].Start.Y);
      var maxY_start = Math.Max(y[0].Start.Y, y[y.Count - 1].Start.Y);

      y = _linesOfInterest.OrderBy(l => l.End.Y).ToList();
      var MinY_end = Math.Min(y[0].End.Y, y[y.Count - 1].End.Y);
      var MaxY_end = Math.Max(y[0].End.Y, y[y.Count - 1].End.Y);

      var minX = Math.Min(minX_start, MinX_end);
      var minY = Math.Min(minY_start, MinY_end);
      var maxX = Math.Max(maxX_start, MaxX_end);
      var maxY = Math.Max(maxY_start, MaxY_end);

      //initiatize grid
      for (int r = minY; r < maxY + 1; r++)      
        for (int c = minX; c < maxX + 1; c++)
          _gridPoints.Add(new Point(r, c));
    }
  }
}
