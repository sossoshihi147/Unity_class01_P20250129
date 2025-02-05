using UnityEngine;

public class homework_03 : MonoBehaviour
{
    private void Awake()
    {
        equation(6 / 2 * (1 + 2));
    }

    private void equation(int answer)
    {
        Debug.Log($"<color=#ff0> 6/2(1+2)= {answer} </color>");
    }
}
