using UnityEngine;

namespace OLIVER
{
    public class homework_09 : MonoBehaviour
    {
        private void Awake()
        {
            float maxFloat = -999.321f;
            sbyte maxFloarToSbyte = 0;
            maxFloarToSbyte = (sbyte)maxFloat;
            LogSystem.LogWithColor(maxFloarToSbyte, "#3f0");
            LogSystem.LogWithColor(maxFloarToSbyte.GetType(), "#3f0");
        }
    }
}
