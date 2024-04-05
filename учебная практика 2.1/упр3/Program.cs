using System;


int[] nums1 = new int[] {1, 2, 3, 4};
int[] nums2 = new int[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
int[] nums3 = new int[] {1, 2, 3, 1};

Console.WriteLine(Check(nums1));
Console.WriteLine(Check(nums2));
Console.WriteLine(Check(nums3));


static bool Check(int[] nums)
{
    bool result = true;
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                result = true;
                
                break;
            }
            else
                result = false;
        }
        
        if (result)
            break;
    }
    
    return result;
}