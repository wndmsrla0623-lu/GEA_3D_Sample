using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;
    public float expRate = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    [ContextMenu("정산")]
    void Settle()
    {
        int hour = playSeconds / 3600;
        int min = (playSeconds % 3600) / 60;
        int sec = playSeconds % 60;

        Debug.Log("플레이 시간 " + hour + "시간" + min + "분" + sec + "초");

        int goldmember = gold / members;
        int redearbonus = gold % members;
        Debug.Log("1인당 골드" + goldmember + ", 리더 보너스" + redearbonus);

        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);
        Debug.Log("경험치" + finalExp + "(기본 " + baseExp + ")");

        int level = finalExp / 100 + 1;
        int nextExp = 100 - (finalExp % 100);

        Debug.Log("Lv " + level + ", 다음 레벨까지 " + nextExp);

        float averageDamage = (float)totalDamage / hits;
        Debug.Log("평균 데미지 " + averageDamage);
    }
}
