using UnityEngine;

public class homework_05 : MonoBehaviour 
{
    // switch 練習
    [SerializeField, Header("血量"), Range(0, 100)]
    private int hp = 100;

    private void Update()
    {
        switch (hp)
        {
            case >=80:
                Debug.Log("<color=#fff>你已經死了</color>");
                break;
            case >=60:
                Debug.Log("<color=#f00>你快死掉了</color>");
                break;
            case >=40:
                Debug.Log("<color=#fa0>警告，快喝水</color>");
                break;
            case >=10:
                Debug.Log("<color=#ff0>你的健康有點狀況</color>");
                break;
            case 0:
                Debug.Log("<color=#7f0>你的血量安全</color>");
                break;
        }
    }
}
