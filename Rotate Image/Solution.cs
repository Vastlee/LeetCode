namespace Rotate_Image {
  internal class Solution {
    public void Rotate(int[][] matrix) {
      int tmp, len;
      len = matrix.Length - 1;

      for(int i = 0; i <= len / 2; i++) {
        for(int i2 = i; i2 < len - i; i2++) {
          tmp = matrix[i][i2];
          matrix[i][i2] = matrix[len - i2][i]; //
          matrix[len - i2][i] = matrix[len - i][len - i2];
          matrix[len - i][len - i2] = matrix[i2][len - i];
          matrix[i2][len - i] = tmp;
        }
      }
    }
  }
}