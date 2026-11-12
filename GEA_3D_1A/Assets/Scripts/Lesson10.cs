using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    private int row;

    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;


        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }

    [ContextMenu("계단")]

    void Stairs()
    {
        int height = 3;
        string result = "";
        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }
}