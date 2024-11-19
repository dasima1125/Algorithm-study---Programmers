using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string skill, string[] skill_trees) {
        int answer = 0;
        
        for (int i = 0; i < skill_trees.Length; i++)
        {
            int count = 0;
            bool check = true;
            Stack<char> stack = new Stack<char>(skill_trees[i].Reverse());
            
            for (int j = 0; j < skill_trees[i].Length; j++)
            {
                char nowtree = stack.Pop();
                if (count < skill.Length && nowtree == skill[count])
                {
                    count++;
                    continue;}
                else if (skill.Contains(nowtree) && nowtree != skill[count])
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                answer++;
            }
        }
        return answer;
    }
}