using System;
using System.Linq;

namespace Reverse_Integer {
  public class Solution {
    public int Reverse(int x) {
      int result;
      string conversion = new string(x.ToString().ToCharArray().Where(num => num != '-').Reverse().ToArray());
      if(x < 0) { conversion = "-" + conversion; }
      int.TryParse(conversion, out result);
      return result;
    }
  }
}