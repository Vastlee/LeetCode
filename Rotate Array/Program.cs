using VastTools;

namespace Rotate_Array;

public class Program {
    public static void Main(string[] args) {
        var solution = new Solution();

        int[] input = { 1, 2, 3, 4, 5, 6, 7 };
        int[] input2 = { 1, 2 };
        int[] input3 = { 1, 2, 3 };

        //5,6,7,1,2,3,4
        solution.Rotate(input, 3);
        input.Log();

        // 2, 1
        solution.Rotate(input2, 1);
        input2.Log();

        //[3,1,2]
        solution.Rotate(input3, 1);
        input3.Log();
    }
}