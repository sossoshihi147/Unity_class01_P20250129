using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 練習_類別及建構子
    /// </summary>
    public class homework_08 : MonoBehaviour
    {
        private void Start()
        {
            homework_08_Boss boss1 = new homework_08_Boss("小粉紅", "玻璃心", 1);
            homework_08_Boss boss2 = new homework_08_Boss("西索", "伸縮自在的愛", 999);

            boss1.Talk();
            boss2.Talk();
        }

    }
}
