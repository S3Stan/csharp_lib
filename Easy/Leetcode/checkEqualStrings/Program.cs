/*

Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
A string is represented by an array if the array elements concatenated in order forms the string.

*/

public class Solution {

    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {

        // concatenate strings
        int word_one_array_length = word1.Length; // get length of word 1
        int word_two_array_length = word2.Length; // get length of word 2

        string combined_string_word1 = ""; // get length of combined
        string combined_string_word2 = ""; // get length of combined

        // combine 
        for(int i = 0; i < word1.Length; i++){
            combined_string_word1 += word1[i]; //
        }

        for(int i = 0; i < word2.Length; i++){
            combined_string_word2 += word2[i]; //
        }

        // check if two strings are equal
        bool areStringsEqual = false;
        if(combined_string_word1 == combined_string_word2){
            areStringsEqual = true; //
        }
        else{
            areStringsEqual = false; //
        }

        return areStringsEqual; // return the total amount
    }
}

class Program {
    static void Main() {

        //temp array
        string[] word1_string = new string[] {"ab", "c"};
        string[] word2_string = new string[] {"a", "bcd"};
        
        // temp array
        Solution solution = new Solution();
        bool result = solution.ArrayStringsAreEqual(word1_string, word2_string); // Change the argument as needed
        string result_of_strings = result.ToString();
        Console.WriteLine($"Are Strings equal: {result_of_strings}");
    }
}