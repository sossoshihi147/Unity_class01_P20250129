using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 列舉 : enumeration，C# 內關鍵字為簡寫 enum
    /// </summary>
    public class Class_05_2_Enumeration : MonoBehaviour
    {
        #region 認識列舉基本用法
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
        #endregion

        #region 定義列舉數值
        // 定義列舉的數值
        /// <summary>
        /// 道具
        /// </summary>
        private enum Item
        {
            None = 0, Coin = 1, RedWater = 10, BlueWater = 15, Chicken = 20
        }
        [SerializeField, Header("道具")]
        private Item item = Item.Chicken;

        // 執行順序 : Awake > Start > Update
        // 開始事件 : 在喚醒事件後執行一次 (初始化)
        private void Start()
        {
            Debug.Log((int)item);
        }
        private void Update()
        {
            // 列舉與判斷式 Switch
            // switch + Tab *2 > 修改 switch_on 為列舉 > Enter * 2 快速完成
            switch (item)
            {
                case Item.None:
                    Debug.Log($"沒有道具 價值:{(int)item}");
                    break;
                case Item.Coin:
                    Debug.Log($"金幣 價值:{(int)item}");
                    break;
                case Item.RedWater:
                    Debug.Log($"紅色藥水 價值:{(int)item}");
                    break;
                case Item.BlueWater:
                    Debug.Log($"藍色藥水 價值:{(int)item}");
                    break;
                case Item.Chicken:
                    Debug.Log($"炸雞 價值:{(int)item}");
                    break;
                default:
                    Debug.Log("這不是道具");
                    break;
            }
            #endregion
        }
    }
}

