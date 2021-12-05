namespace aoc.D04
{
  public class Board
  {
    private List<List<Point>> _points;
    private bool _hasWon;
    private int _score;

    public Board(List<List<Point>> points)
    {
      _points = points;
      _hasWon = false;
      _score = 0;
    }

    public bool HasWon { get { return _hasWon; } }
    public int Score { get { return _score; } }

    public void Update(int num)
    {
      for (int r = 0; r < 5; r++)
      {
        for (int c = 0; c < 5; c++)
        {
          if (num == _points[r][c].Value)
          {
            var p = _points[r][c];
            p.Marked = true;
            _points[r][c] = p;
          }
        }
      }

      if (CheckRowWin() || CheckColumnWin())
      {
        _hasWon = true;
        _score = num * SumOfUnmarkedNumbers();
      }     
    }

    private bool CheckColumnWin()
    {
      for (int c = 0; c < 5; c++)
      {
        var trueCount = 0;

        for (int r = 0; r < 5; r++)
        {
          if (_points[r][c].Marked == true)
            trueCount++;
        }

        if (trueCount == 5)
          return true;
      }

      return false;
    }

    private bool CheckRowWin()
    {
      foreach (var row in _points)
      {
        var trueCount = 0;
        foreach (var p in row)
        {
          if (p.Marked == true)
            trueCount++;
        }       

        if (trueCount == 5)
          return true;
      }

      return false;
    }

    private int SumOfUnmarkedNumbers()
    {
      int sum = 0;

      foreach (var row in _points)
      {
        foreach (var p in row)
        {
          if (p.Marked != true)
            sum += p.Value;
        }
      }

      return sum;
    }
  }
}