/*You are climbing a staircase. It takes n steps to reach the top.
 * Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
 * Example 1:
    * Input: n = 2
    * Output: 2
    * Explanation: There are two ways to climb to the top.
        * 1. 1 step + 1 step
        * 2. 2 steps
 
 * Example 2:
    * Input: n = 3
    * Output: 3
    * Explanation: There are three ways to climb to the top.
        * 1. 1 step + 1 step + 1 step
        * 2. 1 step + 2 steps
        * 3. 2 steps + 1 step*/

//Pseudocode:
//declare variable n
//Console.WriteLine("How many stairs would you like to climb?");
//int userStairs = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"You chose to climb {userStairs} stairs");

//create a method:
//static int stairTracker (int userStairs, int n)
//{
//  if n <= 1, there is only 1 way
//  
//  for (int i = 2; i <= n; i++)
//  {
//
//  }

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many stairs would you like to climb?");
        int userStairs = Convert.ToInt32(Console.ReadLine());
        
        if (userStairs <= 1)
        {
            Console.WriteLine($"You chose to climb 1 stair.");
        }
        else 
        {
            Console.WriteLine($"You chose to climb {userStairs} stairs.");
        }    
       
        int result = stairFormula(userStairs);

        if (result <= 1)
        {
            Console.WriteLine($"There is 1 distinct way to climb 1 stair.");
        }
        else
        {
            Console.WriteLine($"There are {result} distinct ways to climb {userStairs} stairs.");
        }
        
    }

    static int stairFormula(int n)
    {
        if (n <= 1)
            return 1;

        int lastNum1 = 1;
        int lastNum2 = 1;
        

        for (int i = 2; i <= n; i++)
        {     
            int currentNum = lastNum1 + lastNum2;       
            lastNum2 = lastNum1;
            lastNum1 = currentNum;
        }

        return lastNum1;
    }
}
