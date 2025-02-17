using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 裝箱 Boxing 與拆箱 Unboxing
    /// </summary>
    public class Class_09_1_Boxing : MonoBehaviour
    {
        // 實值型別的資料類型
        // 結構、列舉、整數、浮點數、布林值、字元
        // 實值型別的資料會儲存在 Stack 記憶體內
        private int number = 100;

        // 參考型別的資料類型
        // 物件、類別、字串
        // 物件資料類型為參考型別
        private object box;

        private object boxNumber = 50;
        private int count;

        private void Awake()
        {
            // 裝箱
            // 將實值型別資料放到參考型別資料內
            box = number;
            LogSystem.LogWithColor(box.ToString(), "#f33");

            // 拆箱
            // 將參考型別資料放到實值型別資料內
            // 在前方添加 (要轉換的資料類型)
            count = (int)boxNumber;
            LogSystem.LogWithColor(count.ToString(), "#3f3");
        }
    }

}

