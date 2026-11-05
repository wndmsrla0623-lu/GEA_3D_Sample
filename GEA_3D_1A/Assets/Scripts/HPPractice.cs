using UnityEngine;

public class HPPractice : MonoBehaviour
{
    int currentHp = 7;
    int maxHp = 10;

    [ContextMenu("체력")]
    void PrintHP()
    {
        int a = (int)((float)currentHp / maxHp * 100);
        Debug.Log("HP" + a + "%");

        int b = currentHp * 100 / maxHp;
        Debug.Log("HP" + b + "%");
    }
}
