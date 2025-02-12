using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 結構 struct
    /// </summary>
    public class Class_08_2_Struct : MonoBehaviour
    {
        private void Awake()
        {

            Class_08_2_PlayerData player1 = new Class_08_2_PlayerData(2, 30);
            Class_08_2_PlayerData player2 = new Class_08_2_PlayerData(5, 10.4f);
        }

    }
}