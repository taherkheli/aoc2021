namespace aoc.D02
{
  public static class Parser
  {
    public static Instruction[] Parse(string path)
    {
      var lines = File.ReadAllLines(path);
      var instructions = new Instruction[lines.Length];

      for (var i = 0; i < lines.Length; i++)
      {
        var substrings = lines[i].Trim().Split(' ');
        instructions[i] = new Instruction() { Direction = GetDirection(substrings[0]), StepSize = Int32.Parse(substrings[1]) };
      }

      return instructions;
    }

    private static Direction GetDirection(string s)
    {
      return s switch
      {
        "forward" => Direction.Forward,
        "down" => Direction.Down,
        "up" => Direction.Up,
        _ => Direction.Undefined,
      };
    }
  }
}
