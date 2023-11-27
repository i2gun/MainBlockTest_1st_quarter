using System;

public class Get3LetterElements
{
    public static void Main() {
        string[] stringArray = ["Hello", "2", "world", ":-)"];                       // ["2", ":-)"]
        // string[] strings = ["1234", "1567", "-2", "computer science"];           // ["-2"]
        // string[] strings = ["Russia", "Denmark", "Kazan"];                          // []

        int count = 0;

        for (int i = 0; i < stringArray.Length; i++) {
            if (stringArray[i].Length <= 3) {
                string swap = stringArray[count];
                stringArray[count++] = stringArray[i];
                stringArray[i] = swap;
            }
        }

        string[] threeLetterStrings = new string[count];
        Array.Copy(stringArray, threeLetterStrings, count);

        Console.WriteLine("[{0}]", string.Join(", ", threeLetterStrings));
    }
}