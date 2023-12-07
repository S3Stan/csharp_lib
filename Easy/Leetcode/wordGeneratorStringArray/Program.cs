public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int good_word = 0;
        string string_value = "";

        //for each word in word array, check if the word letters completely match the chars word
        for(int i=0; i < words.Length; i++){
            int wordIndex = i;
            for(int j=0; j < words[wordIndex].Length; j++){
                int wordLength = j;
                string actual_word = words[wordIndex]; //get word in 
                int max_count = 0;

        
                for(int k=0; k < chars.Length; k++){
                    if(actual_word[j] == chars[k]){
                        max_count +=1;

                        if(max_count == actual_word.Length){
                            good_word = max_count;
                            //string_value = actual_word;
                        }
                    }
                    else{
                         // do nothing
                    }
                }
                //
            }
        }
        
        return good_word; // return t

        // if 100% of words appear in chars; store word length

        // return the sum of all good strings
    }
}

class Program {
    static void Main() {

        //temp array
        string[] word_string_array = new string[] {"cat", "bt", "hat", "tree"};
        string content_index_string = "atach";
        
        // temp array
        Solution solution = new Solution();
        int result = solution.CountCharacters(word_string_array, content_index_string); // Change the argument as needed
        string result_of_strings = result.ToString();
        Console.WriteLine($"String characters count: {result_of_strings}");
    }
}