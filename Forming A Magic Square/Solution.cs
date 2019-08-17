using System.Collections.Generic;

namespace Forming_A_Magic_Square {
  internal class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
      int result = 0;

      for(int i = 0; i < grid.Length - 2; i++) {
        for(int i2 = 0; i2 < grid[i].Length - 2; i2++) {
          if(IsMagicSquare(GetSquareAtPoint(grid, i, i2))) { result++; }
        }
      }

      return result;
    }

    private int[][] GetSquareAtPoint(int[][] grid, int yPos, int xPos) {
      return new int[][] {
            new int[] { grid[yPos][xPos], grid[yPos][xPos+1], grid[yPos][xPos+2] },
            new int[] { grid[yPos+1][xPos], grid[yPos+1][xPos+1], grid[yPos+1][xPos+2] },
            new int[] { grid[yPos+2][xPos], grid[yPos+2][xPos+1], grid[yPos+2][xPos+2] },
          };
    }

    private bool IsMagicSquare(int[][] square) {
      if(!ValidNumbers(square)) { return false; } else if(!AllEqualSum(square, 15)) { return false; } else return true;
    }

    private bool ValidNumbers(int[][] square) {
      var foundNums = new HashSet<int>();

      for(int i = 0; i < square.Length; i++) {
        for(int i2 = 0; i2 < square[i].Length; i2++) {
          if(foundNums.Contains(square[i][i2])
            || square[i][i2] < 1
            || square[i][i2] > 9) {
            return false;
          } else {
            foundNums.Add(square[i][i2]);
          }
        }
      }
      return true;
    }

    private bool AllEqualSum(int[][] square, int requiredSum) {
      for(int i = 0; i < square.Length; i++) {
        if((square[i][0] + square[i][1] + square[i][2]) != requiredSum) { return false; }
      }

      for(int i = 0; i < square.Length; i++) {
        if((square[0][i] + square[1][i] + square[2][i]) != requiredSum) { return false; }
      }

      if((square[0][0] + square[1][1] + square[2][2]) != requiredSum
        || (square[0][2] + square[1][1] + square[2][0]) != requiredSum) { return false; }

      return true;
    }
  }
}