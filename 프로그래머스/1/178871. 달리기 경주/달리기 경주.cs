using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
     
        Dictionary<string, int> playerIndex = players
            .Select((player, index) => new { player, index })
            .ToDictionary(x => x.player, x => x.index);

        List<string> modifiedPlayers = players.ToList();

        foreach (var calling in callings) {
            if (playerIndex.TryGetValue(calling, out int index) && index > 0) {
            
                string playerToSwap = modifiedPlayers[index - 1];
                modifiedPlayers[index - 1] = calling;
                modifiedPlayers[index] = playerToSwap;

                playerIndex[calling] = index - 1;
                playerIndex[playerToSwap] = index;
            }
        }

        return modifiedPlayers.ToArray();
    }
}