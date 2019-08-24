namespace Plus_One {
  internal class Solution {
    public int[] PlusOne(int[] digits) {
      if(digits == null || digits.Length < 1) {
        return new int[1];
      }

      for(int i = digits.Length - 1; i >= 0; i--) {
        if(digits[i] < 9 || i == 0) {
          digits[i]++;
          break;
        } else {
          digits[i] = 0;
        }
      }

      if(digits[0] == 10) {
        int[] overflow = new int[digits.Length + 1];
        overflow[0] = 1;
        overflow[1] = 0;
        for(int i = 2; i < overflow.Length; i++) {
          overflow[i] = digits[i - 1];
        }
        return overflow;
      }

      return digits;
    }
  }
}