using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 資料類型轉換
    /// </summary>
    public class Class_09_2_DateTypeSwitch : MonoBehaviour
    {
        private void Awake()
        {
            // 隱式轉換 : 不需要另外宣告轉換類型
            // 將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;
            LogSystem.LogWithColor(byte1,"#7f7");
            LogSystem.LogWithColor(byte1.GetType(),"#7f7");
            LogSystem.LogWithColor(int1,"#7f7");
            LogSystem.LogWithColor(int1.GetType(),"#7f7");
            // 隱式轉換 : 將比較小的 byte 放到大的 int
            int1 = byte1;
            LogSystem.LogWithColor(int1,"#7ff");
            LogSystem.LogWithColor(int1.GetType(),"#7ff");


            // 顯示轉換 : 需要宣告轉換的類型
            // 將大的資料放到小的資料內
            int int2 = 100;
            byte byte2 = 0;
            LogSystem.LogWithColor(int2, "#3f0");
            LogSystem.LogWithColor(int2.GetType(), "#3f0");
            LogSystem.LogWithColor(byte2, "#3f0");
            LogSystem.LogWithColor(byte2.GetType(), "#3f0");
            // 顯示轉換 : 將比較大的 int 放到小的 byte
            // 添加(資料類型)
            byte2 = (byte)int2;
            LogSystem.LogWithColor(byte2, "#0f7");
            LogSystem.LogWithColor(byte2.GetType(), "#0f7");

            // 浮點數轉為整數型別，小數點會遺失
            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 =(byte)float1;
            LogSystem.LogWithColor(byte3, "#f0d");

            // 範圍較大的轉換為範圍小的，會導致溢位
            int int3 = 257;
            byte byte4 = 0;
            byte4 = (byte)int3;
            LogSystem.LogWithColor(byte4, "#ff0");

            LogSystem.LogWithColor("-----------", "#ffa");
        }
    }
}