using System;
using System.Collections.Generic;

namespace Common {
  public static class Extensions {
    public static void PrintArray<T>(this T[] arr) {
      for(int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i].ToString());
        if(i + 1 < arr.Length) { Console.Write(", "); } else { Console.WriteLine(); }
      }
    }

    public static void PrintList<T>(this List<T> arr) {
      for(int i = 0; i < arr.Count; i++) {
        Console.Write(arr[i].ToString());
        if(i + 1 < arr.Count) { Console.Write(", "); } else { Console.WriteLine(); }
      }
    }
  }
}