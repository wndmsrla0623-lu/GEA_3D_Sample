using UnityEngine;
using System.Collections.Generic;

public class BattleLog : MonoBehaviour
{
    public int[] damager = { 1200, 3500, 800, 12000, 3500, 950 };

    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]

    void ShowBattleLog()
    {
        foreach (int i in damager)
        {
            if (i > criticalLine) continue;
            
        }
    }
}
