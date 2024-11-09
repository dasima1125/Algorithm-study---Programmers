using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int n, int[] stations, int w)
    {
        int answer = 0;
        int lastCovered = 0;

        foreach (int station in stations)
        {
            int currentCoverageStart = station - w;
            int currentCoverageEnd = station + w;

            if (currentCoverageStart > lastCovered + 1)
            {
                int nonCovered = currentCoverageStart - lastCovered - 1;
                answer += (int)Math.Ceiling((double)nonCovered / (2 * w + 1));
            }

            lastCovered = Math.Max(lastCovered, currentCoverageEnd);
        }

        if (lastCovered < n)
        {
            int nonCovered = n - lastCovered;
            answer += (int)Math.Ceiling((double)nonCovered / (2 * w + 1));
        }

        return answer;
    }
}
