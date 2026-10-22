using UnityEngine;
using TMPro;
using System.Reflection.Emit;

public class KillCountUI : MonoBehaviour
{
    public TMP_Text label;
    void Start()
    {
        Health.killCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        label.text = "KILL " + Health.killCount;
    }
}
