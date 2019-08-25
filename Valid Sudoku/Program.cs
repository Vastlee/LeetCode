using System;
using VastTools;

namespace Valid_Sudoku {
  internal static class Program {
    private static void Main(string[] args) {
      char[][][] input = new char[][][] {
        // Should Evaluate to True
        new char[][] {
          new char[] { '5','3','.','.','7','.','.','.','.' },
          new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
          new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
          new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
          new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
          new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
          new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
          new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
          new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        },

        // Should Evaluate to False
        new char[][] {
          new char[] { '8','3','.','.','7','.','.','.','.'},
          new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.'},
          new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.'},
          new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3'},
          new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
          new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
          new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.'},
          new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5'},
          new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
        },

        // Should Evaluate to False
        new char[][] {
          new char[] { '.','.','4','.','.','.','6','3','.'},
          new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.'},
          new char[] { '5', '.', '.', '.', '.', '.', '.', '9', '.'},
          new char[] { '.', '.', '.', '5', '6', '.', '.', '.', '.'},
          new char[] { '4', '.', '3', '.', '.', '.', '.', '.', '1'},
          new char[] { '.', '.', '.', '7', '.', '.', '.', '.', '.'},
          new char[] { '.', '.', '.', '5', '.', '.', '.', '.', '.'},
          new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.'},
          new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.'}
        }
      };

      Console.WriteLine(new Solution().IsValidSudoku(input[0]));
      Console.WriteLine(new Solution().IsValidSudoku(input[1]));
      Console.WriteLine(new Solution().IsValidSudoku(input[2]));
    }
  }
}