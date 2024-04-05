using System;
using System.Collections.Generic;

int[] candidates = new int[] {10, 1, 2, 7, 6, 1, 5};
int target = 8;

List<List<int>> result = CombinationOfSum(candidates, target);
        
foreach (List<int> combination in result) 
{
    foreach (int num in combination) 
        Console.Write(num + " "); 
    Console.WriteLine();
}


static List<List<int>> CombinationOfSum(int[] candidates, int target) 
{
    Array.Sort(candidates);
        
    List<List<int>> result = new List<List<int>>();
    List<int> combination = new List<int>();
        
    FindCombination(candidates, target, 0, combination, result);
        
    return result;
}

static void FindCombination(int[] candidates, int target, int index, List<int> combination, List<List<int>> result) 
{
    if (target == 0) 
    {
        result.Add(new List<int>(combination));
            
        return;
    }

    for (int i = index; i < candidates.Length; i++)
    {
        if (candidates[i] > target) 
            break;
            
        if (i > index && candidates[i] == candidates[i - 1]) 
            continue;

        combination.Add(candidates[i]);
            
        FindCombination(candidates, target - candidates[i], i + 1, combination, result);
            
        combination.RemoveAt(combination.Count - 1);
    }
}