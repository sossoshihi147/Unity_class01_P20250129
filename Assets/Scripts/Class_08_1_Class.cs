using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 類別 Class : 用來定義一個物件以及他所擁有的資料與功能 (成員)
    /// </summary>
    public class Class_08_1_Class : MonoBehaviour
    {
        private void Awake()
        {
            // 實例化 NPC 並儲存在 npcJack 變數內
           Class_08_1_NPC npcJack = new Class_08_1_NPC("丁小雨"); 
           Class_08_1_NPC npcKID = new Class_08_1_NPC("原來這裡面資料類型是下面宣告的", "原來是這樣");

            npcJack.LogName();
            npcKID.LogName();
            npcJack.Talk();
            npcKID.Talk();
        }
    }
}