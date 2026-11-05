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
        int goldmember = gold / members;
        int redearbonus = gold % members;
        Debug.Log("1인당 골드" + goldmember + ", 리더 보너스" + redearbonus);
    }
}
