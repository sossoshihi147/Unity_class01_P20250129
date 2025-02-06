using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 列舉 : enumeration，C# 內關鍵字為簡寫 enum
    /// </summary>
    public class Class_05_2_Enumeration : MonoBehaviour
    {
        // 列舉 :定義下拉式選單的選項 (通常都是單選)
        // 語法 :
        // 修飾詞 關鍵字 enum 列舉名稱 { 列舉選項 }
        // 定義一個舉例，名稱叫做季節
        // 列舉都是數值，預設從 0 開始
        private enum Season
        {
            // 定義列舉的選項
            Spring, Summer, Autumn, Winter
        }

        // 宣告變數，類型為季節列舉，預設為夏天
        [SerializeField, Header("季節")]
        private Season season = Season.Summer;

        private void Awake()
        {
            // 取得列舉的值 (Get) 抓出值
            Debug.Log(season);
            // 取得列舉的整數值
            Debug.Log((int)season);
            //設定列舉的值 (Set) 修改值
            season = Season.Winter;
            Debug.Log(season);
            // 透過數值設定列舉
            season = (Season)2;
            Debug.Log(season);
        }
    }
}

