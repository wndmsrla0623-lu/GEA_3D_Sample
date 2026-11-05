using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName;
    public int level;
    public float attack;
    public bool isBoss;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    [ContextMenu("플레이어 이름")]
    void Name()
    {
        Debug.Log(name);
    }

    [ContextMenu("레벨")]
    void Level()
    {
        Debug.Log(level);
    }

    [ContextMenu("공격수치")]
    void Attack()
    {
        Debug.Log(attack);
    }
}
