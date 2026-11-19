using UnityEngine;

public class ForeachPractice : MonoBehaviour
{
    public int[] monsterHps = { 0, 35, 0, 80, 12 };

    [ContextMenu("foreach 실습")]

    void CountAlive()
    {
        int aliveCount = 0;
        int hpSum = 0;
        foreach (int hp in monsterHps) ;
        {
            if (hpSum > 0)
            {
                aliveCount++;
                hpSum += hpSum;
            }
        }

        Debug.Log("살아 있는 몬스터" + aliveCount + "마리");
        Debug.Log("남은 체럭 합" + hpSum);

    }
}
