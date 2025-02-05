using UnityEngine;

public class homework_04 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"<color=#8f0>{income(30000)}</color>");
        Debug.Log($"<color=#f00>{surplus(30000, 32000)}</color>");
    }
    /// <summary>
    /// 當月收入
    /// </summary>
    /// <param name="salary">薪水收入</param>
    /// <returns></returns>
    private  bool income(int salary )
    {
        Debug.Log($"<color=#0fff>這個月有收入嗎?</color>");
        return salary > 0;
    }
    /// <summary>
    /// 當月結餘
    /// </summary>
    /// <param name="salary">薪水收入</param>
    /// <param name="expense">費用支出</param>
    /// <returns></returns>
    private bool surplus(int salary , int expense)
    {
        Debug.Log($"<color=#0fff>這個月有結餘嗎?</color>");
        return (salary - expense) > 0;
    }
}
