using System;

public class Solution {
    public int TotalMoney(int n) {
        
        int incrementer_val = 0;
        int totalValue = 0;

        for(int i = 0; i < n; i++){ //for loop
            if(i % 7 == 0){ 
                incrementer_val = (i/7)+1; //get the Monday value
                totalValue += incrementer_val;//add value to new
            }
            else{
                incrementer_val++;
                totalValue += incrementer_val;
            }
        }

        return totalValue; // return the total amount
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();
        int result = solution.TotalMoney(10); // Change the argument as needed
        Console.WriteLine($"Total Money: {result}");
    }
}

// Hercy wants to save money for his first car. He puts money in the Leetcode bank every day.

// He starts by putting in $1 on Monday, the first day. Every day from Tuesday to Sunday, he will put in $1 more than the day before. On every subsequent Monday, he will put in $1 more than the previous Monday.
// Given n, return the total amount of money he will have in the Leetcode bank at the end of the nth day.
