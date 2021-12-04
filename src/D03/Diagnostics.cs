using System.Text;

namespace aoc.D03
{
  public class Diagnostics
  {
    private string[] _codes;
    private int _lineCount;

    public Diagnostics(string[] codes)
    {
      _codes = codes;
      _lineCount = _codes.Length;
    }

    public int Process() 
    {
      int ones = 0;
      int zeroes = 0;
      int iterations = _codes[0].Length;
      var gammaRate_s = new StringBuilder();
      var epsilonRate_s = new StringBuilder();        

      for (int i = 0; i < iterations; i++)
      {
        ones = CountOnes(i);
        zeroes = _lineCount - ones;

        if (ones > zeroes)
        {
          gammaRate_s.Append("1");
          epsilonRate_s.Append("0");
        }
        else
        {
          gammaRate_s.Append("0");
          epsilonRate_s.Append("1");
        }
      }

      int gammaRate = Convert.ToInt32(Convert.ToInt32(gammaRate_s.ToString(), 2).ToString());
      int epsilonRate = Convert.ToInt32(Convert.ToInt32(epsilonRate_s.ToString(), 2).ToString());

      return gammaRate * epsilonRate;
    }

    //given an array of strings, and an index, count ones in that 'column'
    private int CountOnes(int index)
    {
      int ones = 0;

      for (int i = 0; i < _lineCount; i++)
      {
        if (Int32.Parse((_codes[i][index]).ToString()) > 0)
          ones++;
      }

      return ones;
    }
  }
}
