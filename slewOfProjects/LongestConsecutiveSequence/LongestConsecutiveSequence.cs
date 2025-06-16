using System.Collections;

namespace slewOfProjects;

public class LongestConsecutiveSequence
{
    public static void Run()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 231, 1231, 15235, 123123, 201, 202 };
        
        Array.Sort(nums);

        int previousNum = nums[0];
        int currentStreak = 1;
        int maxStreak = 1;
        
        foreach (int num in nums)
        {
            if(num == previousNum + 1)
            {
                
                currentStreak++;
                previousNum = num;
            }
            else
            {
                Console.WriteLine($"Current streak: {currentStreak}");
                
                if (currentStreak > maxStreak)
                {
                    maxStreak = currentStreak;
                }
                
                previousNum = num;
                currentStreak = 1; // Reset streak if not consecutive
            }
            
            
            
        }
        Console.WriteLine($"Max streak: {maxStreak}");
        
        
        
    }
}