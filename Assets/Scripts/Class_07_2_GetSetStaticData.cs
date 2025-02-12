using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 練習取得與設定靜態資料
    /// </summary>
    public class Class_07_2_GetSetStaticData : MonoBehaviour
    {
        // 取得非靜態資料 (成員)
        // 1. 先定義要獲得資料類別的變數
        // 2. 透過變數取得非靜態資料 (成員)
        public Class_07_2_Static class_7_2;

        private void Awake()
        {
            // 取得非靜態變數
            // 變數名稱.非靜態成員
            Debug.Log($"<color=#f3d>非靜態成員 : {class_7_2.inventoryWater}</color>");
            // 取得非靜態屬性
            Debug.Log($"<color=#f3d>非靜態成員 : {class_7_2.skillMain}</color>");
            // 呼叫非靜態方法
            class_7_2.Punch();

            // 取得靜態變數
            // 類別名稱.靜態成員
            Debug.Log($"<color=#f3d>非靜態成員 : {Class_07_2_Static.inventoryProp}</color>");
            // 取得靜態屬性
            Debug.Log($"<color=#f3d>非靜態成員 : {Class_07_2_Static.skillSecond}</color>");
            // 呼叫靜態方法
            Class_07_2_Static.Kick();
        }
    }

}