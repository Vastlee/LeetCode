using System;
using System.Collections.Generic;

namespace Valid_Sudoku {
  internal class Solution {
    public bool IsValidSudoku(char[][] board) {
      HashSet<char>[] rows = new HashSet<char>[9];
      HashSet<char>[] cols = new HashSet<char>[9];

      for(int i = 0; i < rows.Length; i++) {
        rows[i] = new HashSet<char>();
      }

      for(int i = 0; i < cols.Length; i++) {
        cols[i] = new HashSet<char>();
      }

      for(int i = 0; i < board.Length; i++) {
        for(int i2 = 0; i2 < board[i].Length; i2++) {
          if(i % 3 == 0 && i2 % 3 == 0) {
            if(!IsValidMatrix(Extract(board, i, i2, 3, 3))) {
              return false;
            }
          }

          if(!char.IsNumber(board[i][i2])) { continue; }

          if(rows[i].Contains(board[i][i2])) {
            return false;
          } else {
            rows[i].Add(board[i][i2]);
          }

          if(cols[i2].Contains(board[i][i2])) {
            return false;
          } else {
            cols[i2].Add(board[i][i2]);
          }
        }
      }
      return true;
    }

    private bool IsValidMatrix(char[][] matrix) {
      var found = new HashSet<int>();
      int conversion;

      for(int i = 0; i < matrix.Length; i++) {
        for(int i2 = 0; i2 < matrix[i].Length; i2++) {
          if(!char.IsNumber(matrix[i][i2])) { continue; }
          conversion = (int) char.GetNumericValue(matrix[i][i2]);

          if(conversion < 1 || conversion > 9) { return false; }
          if(found.Contains(conversion)) {
            return false;
          } else {
            found.Add(conversion);
          }
        }
      }
      return true;
    }

    private char[][] Extract(char[][] arr, int startRow = 0, int startCol = 0, int rowCount = -1, int colCount = -1) {
      if(startRow > arr.Length - 1) { throw new ArgumentOutOfRangeException($"The Start Row Index [{startRow}] is greater than the last index [{arr.Length - 1}] of the array"); }
      if(rowCount < 1) { throw new ArgumentOutOfRangeException($"The Row Count [{rowCount}] must be a postive number."); }
      if(colCount < 1) { throw new ArgumentOutOfRangeException($"The Column Count [{colCount}] must be a postive number."); }

      char[][] result;

      rowCount = (rowCount < 1) ? arr.Length : rowCount;
      if(rowCount + startRow > arr.Length) {
        rowCount = arr.Length - startRow;
        result = new char[rowCount][];
      } else {
        result = new char[rowCount][];
        rowCount = startRow + rowCount;
      }

      int x, y;

      x = 0;
      for(int i = startRow; i < rowCount; i++) {
        int newRowLen = (colCount + startCol > arr.Length) ? arr.Length - startCol : startCol + colCount;
        result[x] = new char[newRowLen];
        y = 0;

        for(int i2 = startCol; i2 < newRowLen; i2++) {
          result[x][y] = arr[i][i2];
          y++;
        }
        x++;
      }
      return result;
    }
  }
}